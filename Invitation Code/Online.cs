using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading.Tasks;

namespace Invitation
{
    public enum StartType
    {
        Server,Client
    }

    public class NetConnectEventArgs : EventArgs
    {
        public string HostName { get; set; }
        public int Port { get; set; }

        public NetConnectEventArgs(string hostname, int port)
        {
            HostName = hostname;
            Port = port;
        }
    }

    public class NetConnector : IDisposable
    {
        UdpClient client;
        IPEndPoint endpoint;
        Task waitTask;

        public int Port { get; private set; }
        public string HostName { get; private set; }
        public StartType Type { get; private set; }
        
        /// <summary>
        /// 接続が確立しているかです。
        /// </summary>
        public bool IsConnected { get; set; }

        /// <summary>
        /// 相手の接続待ちかどうかです。
        /// </summary>
        public bool IsWaiting { get; set; }

        /// <summary>
        /// 相手のClose()の了解を待っているかどうかです。
        /// </summary>
        public bool IsClosing { get; set; }

        /// <summary>
        /// 接続された時に呼ばれます。
        /// </summary>
        public event EventHandler<NetConnectEventArgs> Connected;

        /// <summary>
        /// 相手がClose()するか、自分がCloseしたのが相手に了解されたときに呼ばれます。s
        /// </summary>
        public event EventHandler<NetConnectEventArgs> Disconnected;

        /// <summary>
        /// ポート番号は省略できます。
        /// サーバーの場合、ホスト名（IP）も省略できます。
        /// </summary>
        /// <param name="type"></param>
        /// <param name="hostname"></param>
        /// <param name="port"></param>
        public NetConnector(StartType type, string hostname = "localhost", int port = 10800)
        {
            Type = type;
            Port = port;
            HostName = hostname;
            Connected = new EventHandler<NetConnectEventArgs>((_, __) =>
                {
                    IsWaiting = false;
                    IsConnected = true;
                });

            Disconnected = new EventHandler<NetConnectEventArgs>((_, __) =>
                {
                    if (client != null)
                        client.Close();
                    if (waitTask != null)
                        waitTask.Dispose();
                    IsConnected = false;
                    IsClosing = false;
                });
        }

        /// <summary>
        /// 通信を開始します。
        /// </summary>
        public void Start()
        {
            client = new UdpClient(Port);
            client.DontFragment = true;
            client.EnableBroadcast = true;

            if (Type == StartType.Client)
            {
                this.Write("SYN");
            }

            waitTask = new Task(Wait);
            waitTask.Start();

            IsWaiting = true;
        }

        /// <summary>
        /// 文を送信します。
        /// </summary>
        /// <param name="text"></param>
        public void Write(string text)
        {
            var sendBytes = Encoding.UTF8.GetBytes(text);
            client.Send(sendBytes, sendBytes.Length, HostName, Port);
        }

        /// <summary>
        /// 送られてきた情報を読みます。
        /// 相手からのClose()を受け取った場合、通信が切れます。
        /// </summary>
        /// <returns></returns>
        public string Read()
        {
            try
            {
                if (client.Available > 0)
                {
                    var read = Encoding.UTF8.GetString(client.Receive(ref endpoint));
                    switch (read)
                    {
                        case "CLS":
                            Write("CLSD");
                            Disconnected(this, new NetConnectEventArgs(HostName, Port));
                            break;
                        case "CLSD":
                            Disconnected(this, new NetConnectEventArgs(HostName, Port));
                            break;
                        default:
                            return read;
                    }
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            return null;
        }


        /// <summary>
        /// 通信が確立するまでひたすら待つ
        /// </summary>
        void Wait()
        {
            while (!IsConnected)
            {
                switch (Read())
                {
                    case "SYN":
                        HostName = endpoint.Address.ToString();
                        Write("ACK");
                        Connected(this, new NetConnectEventArgs(HostName, Port));
                        break;
                    case "ACK":
                        Connected(this, new NetConnectEventArgs(HostName, Port));
                        break;
                    default:
                        System.Threading.Thread.Sleep(100);
                        break;
                }
            }
        }

        /// <summary>
        /// 通信を閉じることを要求します。相手が了解するまで閉じません。
        /// </summary>
        public void Close()
        {
            Write("CLS");
            waitTask = new Task(() =>
                {
                    while (IsConnected)
                    {
                        Read();
                    }
                });
            IsClosing = true;
            waitTask.Start();
        }

        /// <summary>
        /// 通信を強制的に切断します。相手には通知されません。
        /// </summary>
        public void Dispose()
        {
            if (client != null)
                client.Close();
            if (waitTask != null)
                waitTask.Dispose();
            IsConnected = false;
        }
    }
}

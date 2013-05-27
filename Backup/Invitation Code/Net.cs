using System.Net.Sockets;
using System.Net;
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text;
using System.IO;

namespace Invitation
{
    public class Network
    {
        public bool isConnect = false;
        public bool successStart = false;
        public bool isClient = false;
        public string getData;
        public bool got;

        string ip = ""; int port = 10800;

        Encoding encoding;
        UdpClient client = null;
        IPEndPoint remoteEP = null;//受信

        byte[] sendBytes;
        byte[] recvByte;
        public static string nullpo = "nullpo";
        public Network()
        {
            encoding = Encoding.UTF8;
            sendBytes = encoding.GetBytes("");
            //css.Send("hoge"); ... hogeを送信
            //int i = int.Parse("0xFFFF");
        }
        ~Network()
        {
            Close();
        }
        public void Close()
        {
            if (client != null)
            {
                client.Close();
                client = null;
            }
            successStart = false;
            isConnect = false;
        }
        public void ConnectServer()
        {
            try
            {
                port = int.Parse(Interaction.InputBox("ポートを入力してください。", "SetPort", port.ToString(), -1, -1));
            }
            catch
            {
                //MessageBox.Show("数字を入力してね。");
                return;
            }

            try
            {
                client = new UdpClient(port); // 受信port
                client.DontFragment = true;
                client.EnableBroadcast = true;
                //MessageBox.Show("鯖立てたよ");
                successStart = true;
                isClient = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
                Close();
            }
        }
        public void ConnectClient(bool isUsingWindow)
        {
            if (isUsingWindow)
            {
                if (!SetClient())
                {
                    return;
                }
            }
            else
            {
                if (!ReadClient())
                {
                    return;
                }
            }

            try
            {
                client = new UdpClient(port); // 受信port
                //client.Connect(ip, port);
                client.DontFragment = true;
                client.EnableBroadcast = true;

                isClient = true;
                sendBytes = encoding.GetBytes("tsts0");
                client.Send(sendBytes, sendBytes.Length, ip, port);
                successStart = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
                Close();
            }
        }
        private bool ReadClient()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("IPAddress.txt", Encoding.GetEncoding("Shift_JIS"));
                string readdata;
                string[] datas;
                while (true)
                {
                    readdata = sr.ReadLine();
                    if (readdata[0] == '/')
                    {

                    }
                    else if (readdata == null)
                    {
                        break;
                    }
                    else
                    {
                        datas = readdata.Split(':');
                        ip = datas[0]; port = int.Parse(datas[1]);
                        sr.Close();
                        return true;
                    }
                }
                sr.Close();
            }
            catch
            {
                if (sr != null)
                {
                    sr.Close();
                    sr = null;
                }
            }
            return false;
        }
        private bool SetClient()
        {
            ClientInput ci = new ClientInput();
            ci.ClientInputSubstitution(ip, port);
            ci.ShowDialog();
            string a = ci.IP.Replace(" ", "");
            ip = a;
            port = ci.Port;
            return ci.trueclose;
        }

        public void Send(string sendData)
        {
            if (isConnect)
            {
                sendBytes = encoding.GetBytes(sendData);
                client.Send(sendBytes, sendBytes.Length, ip, port);
                Console.WriteLine("Send:" + sendData);
            }
        }


        public string Accept()
        {////
            /*for (int i = 0; i < 5000; i++)
            {*/
                if (client.Available > 0)
                {
                    recvByte = client.Receive(ref remoteEP);
                    return encoding.GetString(recvByte);
                }
            /* System.Threading.Thread.Sleep(1);
             if (i == 4999)
             {
                 MessageBox.Show("接続が切れました。(TLE)");
                 IsConnect = false; 
                 amazon.inconnect();
             }
         }*/
            return nullpo;
        }

        public void Connected()
        {
            if (client.Available > 0)
            {
                try
                {
                    recvByte = client.Receive(ref remoteEP);
                    if (encoding.GetString(recvByte) == "tsts0" && !isClient)
                    {
                        //ホスト
                        ip = remoteEP.Address.ToString();
                        sendBytes = encoding.GetBytes("tsts1");
                        client.Send(sendBytes, sendBytes.Length, ip, port);

                        //通信が確立された
                        //MessageBox.Show("接続されたよ");
                        isConnect = true; successStart = false;
                    }
                    else if (encoding.GetString(recvByte) == "tsts1" && isClient)
                    {
                        //MessageBox.Show("接続されたよ");
                        isConnect = true; successStart = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error: " + ex.Message);
                }
            }
            else
            {
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
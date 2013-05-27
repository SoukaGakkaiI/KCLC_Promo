using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DxLibDLL;
using Microsoft.VisualBasic;
using Monads = Alice.Functional.Monads;
using System.IO;

namespace Invitation.Scenes
{
    public class Menu : IScene
    {
        int selectIndex;
        const int maxSelectIndex = 3;
        KeyState up, down, z, x;
        NetConnector cntr;

        public void Work()
        {
            DX.DrawBox(0, 0, 800, 800, DX.GetColor(0, 200, 200), 1);
            ParseInput();
            ShowMenu();

            // メニュー選択
            if (z.IsDown && (cntr == null || !cntr.IsWaiting))
                switch (selectIndex)
                {
                    case 0:

                        // キャストをErrorモナドに包む
                        var error = new Monads.Error<int>(() =>
                            int.Parse(Interaction.InputBox("Input port.", "Server create", 10080.ToString(), -1, -1)));

                        // エラーでないなら開始
                        if (!error.IsError)
                        {
                            cntr = new NetConnector(StartType.Server, error.Value);
                            cntr.Start();
                        }

                        break;

                    case 1:

                        var input = Interaction.InputBox("Input hostname:port", "Connect", "localhost:10080", -1, -1);

                        // キャストとSplitをErrorモナドに包む
                        var error2 = new Monads.Error<Tuple<int, string>>(() =>
                            Tuple.Create(int.Parse(input.Split(':')[1]), input.Split(':')[0]));

                        // エラーでないなら開始
                        if (!error2.IsError)
                        {
                            cntr = new NetConnector(StartType.Client, error2.Value.Item1, error2.Value.Item2);
                            cntr.Start();
                        }

                        break;

                    case 2:
                        StreamReader sr = null;
                        string input2="";
                        try
                        {
                            sr = new StreamReader("IPAddress.txt", Encoding.GetEncoding("Shift_JIS"));
                            input2 = sr.ReadLine();
                            sr.Close();
                        }
                        catch
                        {
                            if (sr != null)
                            {
                                sr.Close();
                                sr = null;
                            }
                            break;
                        }

                        // キャストとSplitをErrorモナドに包む
                        var error3 = new Monads.Error<Tuple<int, string>>(() =>
                            Tuple.Create(int.Parse(input2.Split(':')[1]), input2.Split(':')[0]));

                        // エラーでないなら開始
                        if (!error3.IsError)
                        {
                            cntr = new NetConnector(StartType.Client, error3.Value.Item1, error3.Value.Item2);
                            cntr.Start();
                        }

                        break;
                }


            // 接続待ち中にキャンセル
            if (x.IsHold && cntr != null && cntr.IsWaiting)
            {
                cntr.Dispose();
                cntr = null;
            }

            // 接続されたら本編に移動
            if (cntr != null && cntr.IsConnected)
            {
                GameMain.ChangeScene(new Promotion(cntr));
            }
        }

        void ParseInput()
        {
            up = Input.GetKeyState(DX.KEY_INPUT_UP);
            down = Input.GetKeyState(DX.KEY_INPUT_DOWN);
            z = Input.GetKeyState(DX.KEY_INPUT_Z);
            x = Input.GetKeyState(DX.KEY_INPUT_X);
        }

        void ShowMenu()
        {
            if (up.IsDown && (cntr == null || !cntr.IsWaiting))
            {
                selectIndex--;
            }
            else if (down.IsDown && (cntr == null || !cntr.IsWaiting))
            {
                selectIndex++;
            }
            if (selectIndex < 0)
                selectIndex = maxSelectIndex-1;
            else if (selectIndex >= maxSelectIndex)
                selectIndex = 0;

            DX.DrawString(100, 100, "Build Server", DX.GetColor(255, 255, 255));
            DX.DrawString(100, 150, "Connect to Server", DX.GetColor(255, 255, 255));
            DX.DrawString(100, 200, "Connect to Server from FileReading", DX.GetColor(255, 255, 255));
            DX.DrawGraph(50, selectIndex * 50 + 100, DXResources.Images["Arrow"], 1);

            if (cntr != null && cntr.IsWaiting)
            {
                DX.DrawString(500, 400, "Connecting Now", DX.GetColor(100, 255, 100));
            }
        }
    }
}

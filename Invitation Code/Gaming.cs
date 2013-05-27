using DxLibDLL;
namespace Invitation
{
    public class Game
    {
        bool isConnect;
        Network net = new Network();
        int arrowMarkGraph;
        Stuff[] stuff;
        public Game()
        {
            DX.SetMouseDispFlag(1);
            arrowMarkGraph = DX.LoadGraph("data\\arrow.bmp");
            stuff = new Stuff[1];
            stuff[0] = new Stuff(0, 0, arrowMarkGraph);
        }
        int mouseX, mouseY,mouseInput;
        int dealStuff;
        string acceptData;
        int acceptNumber;

        bool upper;
        public void Drive()
        {
            DX.DrawBox(0, 0, 800, 800,DX.GetColor(0,200,200),1);
            if (isConnect)
            {
                acceptData=net.Accept();
                if (acceptData != "nullpo")
                {
                    AdaptData();
                }

                if (!upper)
                {
                    DX.GetMousePoint(out mouseX, out mouseY);
                    GetMouse();
                    if (mousePuting)
                    {
                        ClickStuff();
                    }
                    if (dealStuff != -1)
                    {
                        if (mousePress)
                        {
                            stuff[dealStuff].x = mouseX;
                            stuff[dealStuff].y = mouseY;
                            stuff[dealStuff].speedY = 0;
                        }
                        if (mousePull)
                        {
                            stuff[dealStuff].Drag(mouseX, mouseY);
                            dealStuff = -1;
                        }
                    }
                }

                for (int i = 0; i < stuff.Length; i++)
                {
                    stuff[i].Move();
                    stuff[i].Draw();
                    stuff[i].SendData(upper, net, i);
                }
            }
            else
            {
                InputKey();
                DrawWithNoConnect();
            }
        }
        #region 接続前
        int select = 0;
        int sumOfSelect = 3;
        byte[] keyInput = new byte[256];
        bool[] momentPress = new bool[4];
        bool[] inputing = new bool[4];
        int[] keyName = new int[4] { DX.KEY_INPUT_UP, DX.KEY_INPUT_DOWN, DX.KEY_INPUT_Z, DX.KEY_INPUT_X };
        int waitConnectTime = 0;
        void GetKey(int i)
        {
            if (keyInput[keyName[i]] == 1 && !momentPress[i])
            {
                momentPress[i] = true; inputing[i] = true;
            }
            else if (!(keyInput[keyName[i]] == 1))
            {
                momentPress[i] = false; inputing[i] = false;
            }
            else
            {
                inputing[i] = false;
            }
        }
        void InputKey()
        {

            DX.GetHitKeyStateAll(out keyInput[0]);

            for (int i = 0; i < 4; i++)
            {
                GetKey(i);
            }

            if (waitConnectTime > 0)
            {
                waitConnectTime--;
            }
            else if (waitConnectTime == 0)
            {
                if (inputing[0])
                {
                    select--;
                    if (select < 0)
                    {
                        select = sumOfSelect - 1;
                    }
                }
                if (inputing[1])
                {
                    select++;
                    if (select >= sumOfSelect)
                    {
                        select = 0;
                    }
                }

                if (inputing[2])
                {
                    switch (select)
                    {
                        case 0:
                            net.ConnectServer();
                            if (net.successStart)
                            {
                                waitConnectTime = -1;
                            }
                            break;
                        case 1:
                            net.ConnectClient(true);
                            if (net.successStart)
                            {
                                waitConnectTime = 300;
                            }
                            break;
                        case 2:
                            net.ConnectClient(false);
                            if (net.successStart)
                            {
                                waitConnectTime = 300;
                            }
                            break;
                    }
                }
            }
            if (inputing[3])
            {
                net.Close();
                waitConnectTime = 0;
                net.successStart = false;
            }

            if (net.successStart)
            {
                net.Connected();
            }
            if (net.isConnect)
            {
                isConnect = true;
                waitConnectTime = 0;
                upper = net.isClient;//////////
                if (upper)
                {
                    for (int i = 0; i < stuff.Length; i++)
                    {
                        stuff[i].being = false;
                    }
                }
            }
        }
        void DrawWithNoConnect()
        {
            DX.DrawString(100, 100, "Build Server", DX.GetColor(255, 255, 255));
            DX.DrawString(100, 150, "Connect Server From Input", DX.GetColor(255, 255, 255));
            DX.DrawString(100, 200, "Connect Server From TextFile", DX.GetColor(255, 255, 255));
            DX.DrawGraph(50, select * 50 + 100, arrowMarkGraph, 1);

            if (waitConnectTime != 0)
            {
                DX.DrawString(500, 400, "Connecting Now", DX.GetColor(100, 255, 100));
            }
        }
        #endregion
        #region 接続後
        bool mousePress;
        bool mousePuting;
        bool mousePull;
        bool mousePulling;
        void GetMouse()
        {
            mouseInput = DX.GetMouseInput();
            if ((mouseInput&DX.MOUSE_INPUT_LEFT) !=0 && !mousePress)
            {
                mousePress = true; mousePuting = true; mousePull = false;
            }
            else if ((mouseInput & DX.MOUSE_INPUT_LEFT) == 0&&!mousePulling)
            {
                mousePress = false; mousePuting = false; mousePull = true;mousePulling=true;
            }
            else if ((mouseInput & DX.MOUSE_INPUT_LEFT) == 0)
            {
                mousePress = false; mousePuting = false;mousePull=false;
            }
            else
            {
                mousePuting = false; mousePull = false;mousePulling=false;;
            }
        }
        void ClickStuff()
        {
            for (int i = 0; i < stuff.Length;i++ )
            {
                if (stuff[i].JudgePoint(mouseX, mouseY))
                {
                    dealStuff = i;
                }
            }
        }
        string[] acceptedData;
        void AdaptData()
        {
            acceptedData = acceptData.Split(new char[] { ' ' });
            acceptNumber = int.Parse(acceptedData[0]);
            stuff[acceptNumber].x = float.Parse(acceptedData[1]);
            stuff[acceptNumber].y = float.Parse(acceptedData[2]);
            stuff[acceptNumber].speedX = float.Parse(acceptedData[3]);
            stuff[acceptNumber].speedY = float.Parse(acceptedData[4]);
            stuff[acceptNumber].being = true;
        }




        #endregion
    }
}
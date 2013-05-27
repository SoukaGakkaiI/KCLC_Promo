using DxLibDLL;

namespace Invitation
{
    public class Stuff
    {
        public float x, y;
        int graph;
        float gravity = 0.5f;
        public float speedX, speedY;
        int width, height;
        public bool being=true;
        public Stuff(int stuffX, int stuffY, int stuffGraph)
        {
            x = stuffX; y = stuffY; graph = stuffGraph;
            DX.GetGraphSize(graph, out width, out height);
        }
        public void Move()
        {
            if (being)
            {
                x += speedX;
                y += speedY;
                speedY += gravity;

                if (x < height)
                {
                    x = height;
                    speedX = 0;
                }
                else if (x > 800 - height)
                {
                    x = 800 - height;
                    speedX = 0;
                }
            }
        }
        string MakeSendData(int number,float y)
        {
            return number.ToString() + " " + x.ToString() + " " + y.ToString() + " " + speedX.ToString() + " " + speedY.ToString();
        }

        public void SendData(bool upper, Network net, int number)
        {
            if (being)
            {
                if (upper)
                {
                    if (y > 600)
                    {
                        //送信処理
                        being = false;
                        net.Send(MakeSendData(number,y-600));
                    }
                    else if (y < 0)
                    {

                    }
                }
                else
                {
                    if (y > 600 - height)
                    {
                        speedY = 0;
                        y = 600 - height;
                    }
                    else if (y < 0)
                    {
                        //送信処理
                        being = false;
                        net.Send(MakeSendData(number, y + 600));
                    }
                }
            }
        }
        public void Draw()
        {
            if (being)
            {
                DX.DrawGraph((int)x, (int)y, graph, 1);
            }
        }
        public bool JudgePoint(float pointX, float pointY)
        {
            if (being)
            {
                if ((x - pointX) * (x - pointX) + (y - pointY) * (y - pointY) <= height * height) 
                    return true;
                else return false;
            }
            else return false;
        }
        public void Drag(float movedX, float movedY)
        {
            speedX = movedX - x;
            speedY = movedY - y;
            x = movedX; y = movedY;
        }
    }
}
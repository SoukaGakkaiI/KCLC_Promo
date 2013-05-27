using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DxLibDLL;

namespace Invitation
{
    public class Chara : RectOccupy
    {
        public Vector Speed { get; set; }
        public int GraphHandle { get; set; }
        public bool Hold { get; set; }
        public bool Killed { get; set; }
        
        public double Gravity = 1;
        int killedCount = 0;
        public bool Killing = false;
        int[] killedEffect;

        

        static Vector GetGraphSize(int graphHandle)
        {
            int sizeX, sizeY;
            DX.GetGraphSize(graphHandle, out sizeX, out sizeY);
            return new Vector(sizeX, sizeY);
        }

        public Chara(double x, double y, int graphHandle)
            : this(new Vector(x, y), graphHandle) { }

        public Chara(Vector point, int graphHandle)
            : base(point, GetGraphSize(graphHandle))
        {
            GraphHandle = graphHandle;
            Speed = new Vector(0, 0);
        }

        /// <summary>
        /// Chara.Deserialize(string) で使用出来るこのCharaの圧縮形式を出力します。
        /// </summary>
        /// <returns></returns>
        public string Serialize()
        {
            return string.Format("DAT,X={0},Y={1},SIZEX={2},SIZEY={3},SPEEDX={4},SPEEDY={5},NAME={6}",
                this.X, this.Y, this.Size.X, this.Size.Y, this.Speed.X, this.Speed.Y, DXResources.Images.First(x => x.Value == GraphHandle).Key);
        }

        Vector recent = new Vector(-1, -1);
        

        public void Move()
        {
            recent = new Vector(this);
            this.Move(Speed.X, Speed.Y);

            Speed.Y += Gravity;


            if (this.X < 0)
            {
                this.X = 0;
                Speed.X = 0.4 * -Speed.X;
            }

            else if (this.X > 800 - Size.X)
            {
                this.X = 800 - Size.X;
                Speed.X = 0.4 * -Speed.X;
            }

            if (Speed.Y < -31)
            {
                Speed.Y = -31;
            }
        }

        public void Draw()
        {
            if (Killing && killedEffect.Length > killedCount)
            {
                DX.DrawExtendGraph((int)X - 50, (int)Y - 50, (int)(X + Size.X) + 50, (int)(Y + Size.Y) + 50, killedEffect[killedCount], 1);
                killedCount++;
            }
            else if (Killing)
            {
                Killed = true;
            }
            else
            {
                //DX.DrawRotaGraph((int)Center.X, (int)Center.Y, 1, recent.AngleOf(this).Radian, GraphHandle, 1);
                DX.DrawExtendGraph((int)(Center.X - Size.X/2), (int)(Center.Y - Size.Y/2), (int)(Center.X + Size.X/2), (int)(Center.Y + Size.Y/2), GraphHandle, 1);
            }
        }

        public void SetSize(int sizeX,int sizeY)
        {
            Size.X = sizeX;
            Size.Y = sizeY;
        }

        public void Kill(int[] deadEffect)
        {
            Speed = new Vector(0,0);
            Gravity = 0;
            Hold = false;
            Killing = true;
            killedEffect = deadEffect;
        }

        public override bool IsHit<T>(T o)
        {
            return !Killing ? base.IsHit<T>(o) : false;
        }

        public bool IsHitToBoss(double x,double y)
        {
            return !Killing ? Pow(X+Size.X/2-x)+Pow(Y+Size.Y/2-y)<Pow(Size.X/8) : false;
        }
        double Pow(double i)
        {
            return i * i;
        }

        public override Vector Move(Vector vector)
        {
            Speed = vector;
            this.X += vector.X;
            this.Y += vector.Y;
            return this;
        }

        /// <summary>
        /// Chara.Serializeで圧縮されたCharaを復元します。
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static Chara Deserialize(string text)
        {
            var dic = text.Split(',')
                .Where(x => x.Contains('='))
                .Select(x => x.Split('='))
                .ToDictionary(x => x[0], x => x[1]);

            return new Chara(double.Parse(dic["X"]), double.Parse(dic["Y"]), 
                             DXResources.Images.First(x => x.Key == dic["NAME"]).Value)
            {
                Speed = new Vector(double.Parse(dic["SPEEDX"]),double.Parse(dic["SPEEDY"]))
            };
        }
    }
}

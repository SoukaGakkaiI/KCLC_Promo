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
        public bool IsHere { get; set; }
        public int GraphHandle { get; set; }
        
        static double gravity = 0.5;

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

        public void Move()
        {
            this.Move(Speed.X, Speed.Y);
            Speed.Y += gravity;

            if (this.X < Size.X)
            {
                this.X = Size.X;
                Speed.X = -Speed.X;
            }

            else if (this.X > 800 - Size.X)
            {
                this.X = 800 - Size.X;
                Speed.X = -Speed.X;
            }
        }

        public void Draw()
        {
            if (IsHere)
                DX.DrawGraph((int)this.X, (int)this.Y, this.GraphHandle, 1);
        }

        public override bool IsHit<T>(T o)
        {
            return IsHere ? base.IsHit<T>(o) : false;
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

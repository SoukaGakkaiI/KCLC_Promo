using System;

namespace Invitation
{
    public struct Angle
    {
        double _radian;
        
        public double Radian
        {
            get
            {
                return _radian;
            }
            
            set
            {
                _radian = value;
            }
        }
        
        public double Degree
        {
            get
            {
                return ToDegree(_radian);
            }
            set
            {
                _radian = ToRadian(value);
            }
        }
                
        private Angle(double radian)
        {
            _radian = radian;
        }
        
        public static Angle FromRadian(double radian)
        {
            return new Angle(radian);
        }
        
        public static Angle FromDegree(double degree)
        {
            return new Angle(ToRadian(degree));
        }
        
        public static Angle operator+(Angle x, Angle y)
        {
            return Angle.FromRadian(x.Radian + y.Radian);
        }
        
        public static Angle operator-(Angle x, Angle y)
        {
            return Angle.FromRadian(x.Radian + y.Radian);
        }
        
        static double ToRadian(double degree)
        {
            return degree * Math.PI / 180d;
        }

        static double ToDegree(double radian)
        {
            return radian * 180d / Math.PI;
        }
    }
}
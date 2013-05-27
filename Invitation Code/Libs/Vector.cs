using System;
using System.Linq;
using System.Collections.Generic;
using Alice.Extensions;

namespace Invitation
{   
    /// <summary>
    /// Vector. (a tuple of X and Y)
    /// </summary>
    public class Vector
    {
        /// <summary>
        /// Gets or sets the x value.
        /// </summary>
        public double X { get; set; }
  
        /// <summary>
        /// Gets or sets the y value.
        /// </summary>
        public double Y { get; set; }
        
        public Vector() : this(0,0) {}
        
        public Vector(Vector e) : this(e.X, e.Y) {}
        
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Move this vectorr by specified vector.
        /// </summary>
        /// <param name='moveX'>
        /// Distance of X value to move.
        /// </param>
        /// <param name='moveY'>
        /// Distance of Y value to move.
        /// </param>
        public virtual Vector Move(Vector vector)
        {
            return new Vector(this + vector);
        }
        
        /// <summary>
        /// Move this vectorr by specified X value and Y value.
        /// </summary>
        /// <param name='moveX'>
        /// Distance of X value to move.
        /// </param>
        /// <param name='moveY'>
        /// Distance of Y value to move.
        /// </param>
        public virtual Vector Move(double moveX, double moveY)
        {
            return Move(new Vector(moveX,moveY));
        }
        
        /// <summary>
        /// Move this vector by specified angle and distance.
        /// </summary>
        /// <param name='angle'>
        /// Angle to move.
        /// </param>
        /// <param name='distance'>
        /// Distance to move.
        /// </param>\
        public virtual Vector Move(Angle angle, double distance)
        {
            return Move(Math.Cos(angle.Radian) * distance, Math.Sin(angle.Radian) * distance);
        }
        
        /// <summary>
        /// Gets the distance of this and specified vector.
        /// </summary>
        /// <returns>
        /// The distance.
        /// </returns>
        /// <param name='e'>
        /// Vector.
        /// </param>
        public double DistanceOf(Vector e)
        {
            return 
                Math.Sqrt(
                Math.Pow((double)Math.Abs(this.X - e.X), 2d)
              + Math.Pow((double)Math.Abs(this.Y - e.Y), 2d));
        }
        
        /// <summary>
        /// Gets the angle of this and specified vector.
        /// </summary>
        /// <returns>
        /// The angle.
        /// </returns>
        /// <param name='e'>
        /// Vector.
        /// </param>
        public Angle AngleOf(Vector e)
        {
            return Angle.FromRadian(Math.Atan2(e.Y - this.Y, e.X - this.X));
        }
        
        public override string ToString()
        {
            return string.Format("{0},{1}", X, Y);
        }
        
        public static Vector operator+(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }
        
        public static Vector operator-(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y);
        }
        
       
    }
        
    public static class VectorExtension
    {
        public static void MoveMany<T>(this IEnumerable<T> e, double moveX, double moveY)
            where T : Vector
        {
            e.ForEach(x => x.Move(moveX, moveY));
        }

        public static void MoveMany<T>(this IEnumerable<T> e, Angle angle, double distance)
            where T : Vector
        {
            MoveMany(e, Math.Cos(angle.Radian) * distance, Math.Sin(angle.Radian) * distance);
        }
    }
    
}


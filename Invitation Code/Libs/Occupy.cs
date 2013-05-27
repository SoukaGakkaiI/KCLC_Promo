using System;
using System.Linq;
using System.Collections.Generic;

namespace Invitation
{
    /// <summary>
    /// Occupy.
    /// </summary>
    public abstract class Occupy : Vector
    {
        public Occupy(double x, double y) : base(x,y) {}
        
        /// <summary>
        /// Determines whether this occupy is hit the specified vector.
        /// </summary>
        /// <returns>
        /// <c>true</c> if this occupy is hit the specified vector; otherwise, <c>false</c>.
        /// </returns>
        /// <param name='o'>
        /// The occupy.
        /// </param>
        public abstract bool IsHit<T>(T o)
            where T : Vector;
    }
    
    /// <summary>
    /// Circle occupy.
    /// </summary>
    public class CircleOccupy : Occupy
    {
        public CircleOccupy() : this(0d, 0d, 0d) {}
        
        public CircleOccupy(double x, double y, double radius) : base(x,y)
        {
            Radius = radius;
        }
        
        public CircleOccupy(Vector center, double radius) : this(center.X, center.Y, radius) {}
        
        /// <summary>
        /// Gets or sets the radius of this circle.
        /// </summary>
        public double Radius { get; set; }
        
        public override bool IsHit<T>(T o)
        {
            if(typeof(T) == typeof(CircleOccupy))
                return this.DistanceOf(o) 
                    <= this.Radius + (o as CircleOccupy).Radius;
            else if(typeof(T) == typeof(RectOccupy))
                return (o as RectOccupy).IsHit(this.Clock(this.AngleOf((o as RectOccupy).Center)));
            else
                return this.DistanceOf(o) <= this.Radius;
        }
        
        /// <summary>
        /// Gets a point on an arc of this circle by the specified angle.
        /// </summary>
        /// <param name='angle'>
        /// Angle.
        /// </param>
        public Vector Clock(Angle angle)
        {
            return new Vector(Math.Cos(angle.Radian) * this.Radius, Math.Sin(angle.Radian) * this.Radius);
        }
    }
    
    /// <summary>
    /// Rect occupy.
    /// </summary>
    public class RectOccupy : Occupy
    {
        public RectOccupy() : this(0d, 0d, 0d, 0d) {}
        
        public RectOccupy(double x, double y, double sizeX, double sizeY) : base(x, y)
        {
            Size = new Vector(sizeX, sizeY);
        }
        
        public RectOccupy(Vector startPoint, Vector size) : this(startPoint.X, startPoint.Y, size.X, size.Y) {}
        
        /// <summary>
        /// Gets or sets the size of this rect.
        /// </summary>
        public Vector Size { get; set; }
        
        /// <summary>
        /// Gets the points of this rect.
        /// The count of points is always 4. 
        /// </summary>
        public IEnumerable<Vector> Points 
        {
            get 
            {
                return new Vector[]
                {
                    this,
                    new Vector(this.X + this.Size.X, this.Y),
                    new Vector(this.X, this.Y + this.Size.Y),
                    new Vector(this.X + this.Size.X, this.Y + this.Size.Y)
                };
            }
        }
        
        /// <summary>
        /// Gets the center point of this rect.
        /// </summary>
        public Vector Center
        {
            get
            {
                return new Vector(this.X + this.Size.X / 2, this.Y + this.Size.Y / 2);
            }
        }
        
        public override bool IsHit<T>(T o)
        {
            if(typeof(T) == typeof(CircleOccupy))
                return this.IsHit((o as CircleOccupy).Clock(o.AngleOf(this.Center)));
            else if(typeof(T) == typeof(RectOccupy))
                return Points.Where(x => (o as RectOccupy).IsHit(x))
                             .Any();
            else
                return this.X <= o.X && o.X <= this.X + this.Size.X
                    && this.Y <= o.Y && o.Y <= this.Y + this.Size.Y;
        }
    }
}


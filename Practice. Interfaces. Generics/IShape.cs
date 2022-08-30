using System;
using System.Collections.Generic;

namespace SoftServe_IT_Academy.Practice._Interfaces._Generics
{
    public interface IShape : ICloneable
    {
        double Area() => 0;
    }

    public class Rectangle : IShape, ICloneable
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area() => Length * Width;
        object ICloneable.Clone() => this.MemberwiseClone();
    }

    public class Trapezoid : IShape, ICloneable
    {
        public double Length1 { get; set; }
        public double Length2 { get; set; }
        public double Width { get; set; }
        public double Area() => 0.5 * Width * (Length1 + Length2);
        object ICloneable.Clone() => this.MemberwiseClone();
    }

    public class Room<T> : ICloneable, IComparable
        where T : IShape
    {
        public double Height { get; set; }
        public T Floor { get; set; }
        public double Volume() => Height * Floor.Area();
        public object Clone() => new Room<T> { Height = this.Height, Floor = (T)this.Floor.Clone() };

        public int CompareTo(object obj)
        {
            Room<T> room = obj as Room<T>;
            if (room != null)
            {
                return Floor.Area().CompareTo(room.Floor.Area());
            }
            else
            {
                throw new Exception("Cannot compare!");
            }
        }
    }

    public class RoomComparerByVolume<T> : IComparer<Room<T>>
       where T : IShape
    {
        public int Compare(Room<T> r1, Room<T> r2)
        {
            if (r1.Volume() > r2.Volume())
            {
                return 1;
            }
            else if (r1.Volume() < r2.Volume())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}

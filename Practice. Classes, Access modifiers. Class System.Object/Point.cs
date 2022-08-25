using System;

namespace AccediaTest
{
    public class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        internal int[] GetXYPair() => new int[2] { this.x, this.y };

        protected internal double Distance(int x, int y)
        {
            return Math.Sqrt(Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2));
        }

        protected internal double Distance(Point point)
        {
            return Math.Sqrt(Math.Pow(this.x - point.x, 2) + Math.Pow(this.y - point.y, 2));
        }

        public static explicit operator double(Point point)
        {
            return Math.Sqrt(Math.Pow(point.x - 0, 2) + Math.Pow(point.y - 0, 2));
        }
    }
}

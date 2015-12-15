using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point()
        {
            X = 1;
            Y = 2;
        }
        public Point(int x, int y) : this()
        {
            X = x;
            Y = y;
        }

        public static implicit operator CompareTo(Point other)
        {
            return other.CompareTo()
        }
    }
}

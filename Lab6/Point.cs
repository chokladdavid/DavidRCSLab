using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Lab6;

namespace Lab6
{
    class Point
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

        public static implicit operator Point3D(Point point)
        {
            return new Point3D() {X = point.X, Y = point.Y, Z = 0};
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D()
        {
            X = 1;
            Y = 2;
            Z = 3;
        }
        public Point3D(int x, int y, int z) : this()
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}

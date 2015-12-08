using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Point
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

        //int y, x;
        //public void SetX(int x)
        //{
        //    this.x = x;
        //}
        //public int GetX()
        //{
        //    return x;
        //}
        //public void SetY(int y)
        //{
        //    this.y = y;
        //}
        //public int GetY()
        //{
        //    return y;
        //}
    }
}

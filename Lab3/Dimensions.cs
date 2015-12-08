using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Dimensions
    {
        double height;
        double width;
        double depth;
        public void SetHeight(double height)
        {
            this.height = height;
        }
        public double GetHeight()
        {
            return height;
        }
        public void SetWidth(double width)
        {
            this.width = width;
        }
        public double GetWidth()
        {
            return width;
        }
        public void SetDepth(double depth)
        {
            this.depth = depth;
        }
        public double GetDepth()
        {
            return depth;
        }
    }
}

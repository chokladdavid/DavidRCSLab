using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Circle
    {
        double diameter;
        Point center;
        public void SetDiameter(double diameter)
        {
            this.diameter = diameter;
        }
        public double GetDiameter()
        {
            return diameter;
        }
        public double GetCircumference()
        {
            return diameter * Math.PI;
        }
        public void SetCenter(Point point)
        {
            this.center = point;
        }
        public Point GetCenter()
        {
            return center;
        }
    }
}

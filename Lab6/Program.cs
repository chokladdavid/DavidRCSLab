﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            float myFloat = 2.2f;
            long myLong = 234L;
            char myChar = '#';
            string myString = "string";
            ulong myUlong = 567UL;

            int tal1 = 7, tal2 = 13;


            Point point = new Point(2, 3);
            Point3D point3D = point;

            MyDoubleType mtd1 = new MyDoubleType(2.3);
            MyDoubleType mtd2 = mtd1 * 3;
            MyDoubleType mtd3 = mtd1 + mtd2;
            MyDoubleType mtd4 = new MyDoubleType(7.7);

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}",
                mtd1, mtd2, mtd3, mtd1 == mtd4, mtd4 - mtd1, mtd1 + mtd2 - mtd3 - mtd4, mtd1 < mtd4);
        }
    }
}

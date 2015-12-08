using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person kalle = new Person();
            kalle.SetName("Kalle");
            Console.WriteLine(kalle.GetName());

            Person lisa = new Person();
            lisa.SetName("Lisa");
            Console.WriteLine(lisa.GetName());

            Circle cirkle1 = new Circle();
            cirkle1.SetDiameter(5.5);
            Console.WriteLine(cirkle1.GetCircumference());

            Circle circle2 = new Circle();
            circle2.SetDiameter(2.0);
            Console.WriteLine(circle2.GetCircumference());

            Point point = new Point();
            //point.SetX(5);
            //point.SetY(3);

            Circle coordinateCircle = new Circle();
            coordinateCircle.SetDiameter(7.3);
            coordinateCircle.SetCenter(point);


            Dimensions mediumTableDimentions = new Dimensions();
            mediumTableDimentions.SetHeight(0.8);
            mediumTableDimentions.SetWidth(1.4);
            mediumTableDimentions.SetDepth(0.25);

            Table mediumTable = new Table();
            mediumTable.SetMaterials("palm tree wood", "glass", "iron", "plastic");
            mediumTable.SetSize(mediumTableDimentions);
            Console.WriteLine($"This table is made of: {mediumTable.GetMaterials()}.\r\nIt's size is: {mediumTable.GetSize()}.");


            Dimensions mediumChairDimentions = new Dimensions();
            mediumChairDimentions.SetHeight(1.1);
            mediumChairDimentions.SetWidth(0.4);
            mediumChairDimentions.SetDepth(0.45);

            Chair mediumChair = new Chair();
            mediumChair.SetMaterials("iron", "wool", "mat fabric");
            mediumChair.SetSize(mediumChairDimentions);
            mediumChair.SetSeatHight(0.5);
            Console.WriteLine($"This chair is made of: {mediumChair.GetMaterials()}.\r\nIt's size is: {mediumChair.GetSize()}. The seat is {mediumChair.GetSeatHight()} high upp.");

            Console.ReadLine();
        }
    }
}

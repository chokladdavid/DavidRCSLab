using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Car : IComparable<Car>
    {
        private string brand;
        private int numberOfGears;
        private string collor;
        private string type;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int NumberOfGears
        {
            get { return numberOfGears; }
            set { numberOfGears = value; }
        }
        public string Collor
        {
            get { return collor; }
            set { collor = value; }
        }
        public string Type
        {
            get { return type; }
            set
            {
                var validValue = value == "kombi" || value == "Kombi" || value == "kupe" || value == "Kupe";
                if (validValue)
                    type = value;
                //else
                //    throw new Exception("Not a valid type!");
            }
        }
        public void Drive()
        {
            Console.WriteLine("brum brum");
        }

        public int CompareTo(Car other)
        {
            return this.NumberOfGears.CompareTo(other.NumberOfGears);
        }

        //public static explicit operator Suv(Car car)
        //{
        //    return new Suv()
        //    {
        //        Brand = car.Brand,
        //        NumberOfGears = car.NumberOfGears,
        //        Collor = car.Collor,
        //        Type = car.Type
        //    };
        //}         Får inte göra en egen tpkonvertiring från/till ärvande klass.
    }
}

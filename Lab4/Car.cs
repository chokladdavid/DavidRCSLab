using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Car
    {
        private string brand;
        private char numberOfGears;
        private string collor;
        private string type;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public char NumberOfGears
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

    }
}

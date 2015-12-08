using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Bike
    {
        private int gears;
        private string brand;
        private string type;
        private string[] colors;
        static int numberOfCity;
        static int numberOfMountain;
        static int numberOfTandem;
        static int numberOfCountry;
        static int numberOfOther;
        public int NumberOfCity
        {
            get { return numberOfCity; }
        }
        public int NumberOfMountain
        {
            get { return numberOfMountain; }
        }
        public int NumberOfTandem
        {
            get { return numberOfTandem; }
        }
        public int NumberOfCountry
        {
            get { return numberOfCountry; }
        }
        public int NumberOfOther
        {
            get { return numberOfOther; }
        }
        public int Gears
        {
            get { return gears; }
            set
            {
                var validValue = value >= 0 && value != 1;
                if (validValue)
                    gears = value;
                else
                    throw new Exception("Not a valid value!");

            }
        }
        public string Brand
        {
            get { return brand; }
            set
            {
                var validValue = value != null && value.Length < 15;
                if (validValue)
                    brand = value;
                else
                    throw new Exception("Not a valid value!");
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                if (value.ToLower() == "city" || value == "mountain" || value == "tandem" || value == "country" || value == "other")
                    type = value;
                else
                    throw new Exception("Not a valid value!");
            }
        }
        public string[] Colors
        {
            get { return colors; }
            set
            {
                colors = new string[value.Length];
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] != null)
                        colors[i] = value[i];
                    else
                        throw new Exception("All color values was not valid!");
                }
            }
        }
        static Bike()
        {
            numberOfCity = 0;
            numberOfCountry = 0;
            numberOfMountain = 0;
            numberOfTandem = 0;
        }
        public Bike()
        {
            Gears = 0;
            Brand = "Monark";
            Type = "other";
            string[] array = new string[2] { "black", "white"};
            Colors = array;
            numberOfOther++;
        }
        public Bike(int gears, string brand, string type, params string[] collors) : this()
        {
            Gears = gears;
            Brand = brand;
            Type = type;
            Colors = collors;
            if (type != "other")
            {
                numberOfOther--;
                if (type == "city")
                    numberOfCity++;
                else if (type == "mountain")
                    numberOfMountain++;
                else if (type == "tandem")
                    numberOfTandem++;
                else
                    numberOfCountry++;
            }
        }
        public override string ToString() => $"Gears: {Gears} Brand: {Brand} Type: {Type} Collors: {string.Join(", ", Colors)}";
    }
}

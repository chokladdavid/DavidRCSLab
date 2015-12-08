using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Shirt
    {
        private string type;
        private string motif;
        private string size;
        private string[] colors;
        static int numberOfNormal;
        static int numberOfT_shirt;
        static int numberOfTankTop;
        static int numberOfHoddie;
        static int numberOfBlouse;
        static int numberOfOther;
        public string Type
        {
            get { return type; }
            set
            {
                var validValue = value == "normal" || value == "T-shirt" || value == "tank top" || value == "hoddie" || value == "blouse" || value == "other";
                if (validValue)
                    type = value;
                else
                    throw new Exception("Not a valid value!");
            }
        }
        public string Motif
        {
            get { return motif; }
            set
            {
                if(value != null)
                    motif = value;
                else
                    throw new Exception("You did not enter enything!");
            }
        }
        public string Size
        {
            get { return size; }
            set
            {
                if (value != null)
                    motif = value;
                else
                    throw new Exception("You did not enter enything!");
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
        static Shirt()
        {
            numberOfNormal = 0;
            numberOfT_shirt = 0;
            numberOfTankTop = 0;
            numberOfHoddie = 0;
            numberOfBlouse = 0;
            numberOfOther = 0;
        }
        public Shirt()
        {
            Type = "other";
            Motif = "none";
            Size = "large";
            string[] array = new string[1] {"white"};
            Colors = array;
            numberOfNormal++;
        }
        public Shirt(string type, string motif, string size, params string[] colors) : this()
        {
            Type = type;
            Motif = motif;
            Size = size;
            Colors = colors;
            if(type != "normal")
            {
                numberOfNormal--;
                if (type == "T-shirt")
                    numberOfT_shirt++;
                else if (type == "tank top")
                    numberOfTankTop++;
                else if (type == "hoddie")
                    numberOfHoddie++;
                else if (type == "blouse")
                    numberOfBlouse++;
                else
                    numberOfOther++;
            }
        }
        public override string ToString() => $"Type: {Type} Motif: {Motif} Size: {Size} Color: {string.Join(", ", colors)}";
    }
}

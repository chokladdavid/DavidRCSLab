using System;

namespace Lab3
{
    class Chair
    {
        string[] materials;
        Dimensions size;
        double seatHight;
        public void SetMaterials(params string[] array)
        {
            this.materials = array;
        }
        public string GetMaterials()
        {
            string materialString = "";
            int loopIf = 0;
            foreach (string item in materials)
            {
                if (loopIf > 0)
                    materialString += ", ";
                loopIf++;
                materialString += item;

            }
            return materialString;
        }
        public void SetSize(Dimensions dimentions)
        {
            this.size = dimentions;
        }
        public string GetSize()
        {
            string sizeString = "";
            sizeString += ($"{size.GetHeight()}m high, {size.GetWidth()}m wide, {size.GetDepth()}m long");
            return sizeString;
        }
        public void SetSeatHight(double seatHight)
        {
            this.seatHight = seatHight;
        }
        public double GetSeatHight()
        {
            return seatHight;
        }
    }
}

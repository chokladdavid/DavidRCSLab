using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Table
    {
        string[] materials;
        Dimensions size;
        public void SetMaterials(params string[] array)
        {
            this.materials = array;
        }
        public string GetMaterials()
        {
            string materialSring = "";
            int loopIf = 0;
            foreach (string item in materials)
            {
                if (loopIf > 0)
                    materialSring += ", ";
                loopIf++;
                materialSring += item;

            }
            return materialSring;
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
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_Assement
{
    class Plate : StockItem
    {
        private string type;

        public string Type
        {
            get { return type; }
            set
            {
                if (value.ToLower() == "flat" || value.ToLower() == "deep")
                    type = value.ToLower();
                else
                    throw new Exception("Wrong shape!");
            }
        }
        public override string ToString() => 
            $"Plate type: {Type} {base.ToString()}";
    }
}

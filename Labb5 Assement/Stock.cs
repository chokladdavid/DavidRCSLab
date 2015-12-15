using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_Assement
{
    class Stock
    {
        int counter = 0;

        public StockItem[] StockItems = new StockItem[10];
        public StockItem this[int index]
        {
            get
            {
                if (index >= 0 && index < StockItems.Length)
                    return StockItems[index];
                else
                    throw new Exception("Out of boundary");
            }
           private set
            {
                if (index >= 0 && index < StockItems.Length)
                    StockItems[index] = value;
                throw new Exception("Out of boundary");
            }
        }

        public void AddItem(StockItem item)
        {

            StockItems[counter] = item;
            counter++;
        }

        public StockItem GetItem(int itemId)
        {
            foreach (StockItem item in StockItems)
            {
                if (item.Id == itemId)
                    return item;
            }
            throw new Exception("No item with that Id!");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order
    {
      public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();
        public double SubtotalCost
        {
            get
            {
                double price = 0.0;
                for(int i = 0; i < Items.Count; i++)
                {
                    price += Items[i].Price;
                }
                if(price < 0)
                {
                    price = 0;
                }
                return price;
            }
        }
        public double SalesTaxRate { get; protected set; }
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }
        public double TotalCost
        {
            get
            {
                return SalesTaxCost + SubtotalCost;
            }
        }
    }
}

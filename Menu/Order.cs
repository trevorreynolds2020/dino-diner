using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order
    {
        /// <summary>
        /// Stores order items
        /// </summary>
      public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();
        /// <summary>
        /// Calculates the subtotal cost of all order items
        /// </summary>
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
        /// <summary>
        /// Stores the tax rate
        /// </summary>
        public double SalesTaxRate { get; protected set; }
        /// <summary>
        /// Calculates the tax cost based off of the rate and total
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }
        /// <summary>
        /// Calculates total cost of an order
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SalesTaxCost + SubtotalCost;
            }
        }
    }
}

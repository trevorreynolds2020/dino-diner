using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Stores order items
        /// </summary>
        //public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();
        
        private List<IOrderItem> items;
        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }
        /// <summary>
        /// Calculates the subtotal cost of all order items
        /// </summary>
        
        public double SubtotalCost
        {
            get
            {
                double price = 0.0;
                for(int i = 0; i < Items.Length; i++)
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
        public double SalesTaxRate
        {
            get { return SalesTaxRate; }
            set
            {
                if (value < 0) return;
                SalesTaxRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
        }
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
        /// <summary>
        /// Constructs order instance
        /// </summary>
        public Order()
        {
            items = new List<IOrderItem>();
        }
        /// <summary>
        /// Adds item to menu
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }
        /// <summary>
        /// Removes the item from the list
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
        }
        /// <summary>
        /// When the collection of items is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

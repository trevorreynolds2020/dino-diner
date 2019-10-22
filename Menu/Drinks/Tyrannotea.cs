using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public class Tyrannotea:Drink, INotifyPropertyChanged, IOrderItem
    {
        public bool Sweet { get; set; } = false;
        public bool Lemon = false;
        public Size size;

        /// <summary>
        /// An event handler for PropertChanged events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Calls PropertChangedEventHandler if a specific property changes
        /// </summary>
        /// <param name="propertyName"></param>
        protected void INotifyIfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = .99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
            }
            get { return size; }
        }
        public Tyrannotea()
        {
            Price = 0;
            Calories = 0;
            Ice = true;
            ingredients.Add("Water");
            ingredients.Add("Tea");
            ingredients.Add("Lemon");
            ingredients.Add("Cane Sugar");
        }

        public void AddLemon()
        {
            Lemon = true;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }

        public void AddSweetner()
        {
            Sweet = true;
            Calories *= 2;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        public void NoSweetner()
        {
            if(Sweet)
            {
                Sweet = false;
                Calories /= 2;
            }
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }

        public override string ToString()
        {
            if (Sweet) return $"{Size} Sweet Tyrannotea";
            else return $"{Size} Tyrannotea";
        }
        /// <summary>
        /// Gets a description of the order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// Special order instructions
        /// if no special instructions return an empty array
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Fryceritops : Side, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Enum for the size
        /// </summary>
        private Size size;

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
        /// <summary>
        /// Small, medium, large
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
                INotifyIfPropertyChanged("Price");
                INotifyIfPropertyChanged("Calories");
            }
            get { return size; }
        }
        /// <summary>
        /// Stores the ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }
        }
        /// <summary>
        /// Initializes the info and ingredients for the side
        /// </summary>
        public Fryceritops()
        {
            Price = 0.99;
            Calories = 222;
        }
        /// <summary>
        /// Returns the name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Fryceritops";
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
                return special.ToArray();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class JurassicJava : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Leaves room for cream when set true
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        /// <summary>
        /// Indicates whether or not it's decaf
        /// </summary>
        public bool Decaf { get; set; } = false;
        /// <summary>
        /// small, medium, or large
        /// </summary>
        private Size size;
        /// <summary>
        /// small, medium, or large
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
                INotifyIfPropertyChanged("Price");
                INotifyIfPropertyChanged("Calories");
                INotifyIfPropertyChanged("Description");
            }
            get { return size; }
        }
        /// <summary>
        /// Changes room for cream bool
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
            INotifyIfPropertyChanged("Description");
        }
        
        /// <summary>
        /// Adds ice
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
            INotifyIfPropertyChanged("Description");
        }
        /// <summary>
        /// Changes coffee to decaf
        /// </summary>
        public void DecafJava()
        {
            this.Decaf = true;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
            INotifyIfPropertyChanged("Description");
        }
        /// <summary>
        /// returns a description
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Returns special instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (RoomForCream) special.Add("Hold Cream");
                if (Ice == true) special.Add("Add Ice");
                return special.ToArray();
            }
        }
        /// <summary>
        /// Variable to handle property change
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
        /// Returns a string with the coffee name/type
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Decaf) { return $"{Size} Decaf Jurassic Java"; }
            else { return $"{Size} Jurassic Java"; }
        }
        /// <summary>
        /// Constructs the coffee with default properties 
        /// </summary>
        public JurassicJava()
        {

            Ice = false;
            Price = 0.59;
            Calories = 2;
        }
        /// <summary>
        /// List of ingredients in coffee
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Coffee");
                return ingredients;
            }
        }

    }
}
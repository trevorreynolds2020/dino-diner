using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class JurassicJava : Drink, IOrderItem, INotifyPropertyChanged
    {

        public bool RoomForCream { get; set; } = false;
   
        public bool Decaf { get; set; } = false;
  
        private Size size;

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
            }
            get { return size; }
        }

        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Method to make coffee decaf

        public void AddIce()
        {
            this.Ice = true;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        public void DecafJava()
        {
            this.Decaf = true;
        }
        
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }


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

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Calls PropertChangedEventHandler if a specific property changes
        /// </summary>
        /// <param name="propertyName"></param>
        protected void INotifyIfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public override string ToString()
        {
            if (Decaf) { return $"{Size} Decaf Jurassic Java"; }
            else { return $"{Size} Jurassic Java"; }
        }
        public JurassicJava()
        {

            Ice = false;
            Price = 0.59;
            Calories = 2;
        }

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
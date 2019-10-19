using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public class JurassicJava:Drink,  INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void INotifyIfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Size size;
        public bool RoomForCream { get; set; } = false;
        public bool Decaf { get; set; } = false;
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = .59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = .99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
            }
            get { return size; }
        }
        public JurassicJava()
        {
            size = Size.Small;
            Ice = false;
            ingredients.Add("Water");
            ingredients.Add("Coffee");
        }
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        public void AddIce()
        {
            Ice = true;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }

        public override string ToString()
        {
            if (Decaf) return $"{Size} Decaf Jurassic Java";
            else return $"{Size} Jurassic Java";
        }
        /// <summary>
        /// Gets a description of the order item
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// Special order instructions
        /// if no special instructions return an empty array
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!RoomForCream) special.Add("Leave Room For Cream");
                if (!Ice) special.Add("Add Ice");
                return special.ToArray();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class JurassicJava:Drink
    {
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
        }
        public void AddIce()
        {
            Ice = true;
        }

        public override string ToString()
        {
            if (Decaf) return $"{Size} Decaf Jurassic Java";
            else return $"{Size} Jurassic Java";
        }
    }
}

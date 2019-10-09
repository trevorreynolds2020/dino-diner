using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class JurrasicJava:Drink
    {
        public Size size;
        public bool RoomForCream = false;
        public bool Defac = false;
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
        public JurrasicJava()
        {
            Price = 0;
            Calories = 0;
            Ice = false;
            Ingredients.Add("Water");
            Ingredients.Add("Coffee");
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
            if (Defac) return $"{Size} Decaf Jurrasic Java";
            else return $"{Size} Decaf Jurrasic Java";
        }
    }
}

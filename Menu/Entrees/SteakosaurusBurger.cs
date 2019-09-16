using System.Collections.Generic;


namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

        public bool Bun = true;
        public bool Pickle = true;
        public bool Ketchup = true;
        public bool Mustard = true;
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Pickle) ingredients.Add("Pickle");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        public void HoldBun()
        {
            Bun = false;
        }

        public void HoldPickle()
        {
            Pickle = false;
        }
        public void HoldKetchup()
        {
            Ketchup = false;
        }
        public void HoldMustard()
        {
            Mustard = false;
        }
    }
}

using System.Collections.Generic;


namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

        public bool Bun = true;
        public bool Lettuce = true;
        public bool Tomato = true;
        public bool Onion = true;
        public bool Pickle = true;
        public bool Ketchup = true;
        public bool Mustard = true;
        public bool Mayo = true;
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Lettuce) ingredients.Add("Lettuce");
                if (Tomato) ingredients.Add("Tomato");
                if (Mustard) ingredients.Add("Mustard");
                if (Mustard) ingredients.Add("Mustard");
                if (Mustard) ingredients.Add("Mustard");
                if (Mustard) ingredients.Add("Mustard");

                return ingredients;
            }
        }

        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        public void HoldBun()
        {
            Bun = false;
        }

        public void HoldLettuce()
        {
            Lettuce = false;
        }
        public void HoldTomato()
        {
            Tomato = false;
        }
        public void HoldOnion()
        {
            Onion = false;
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
        public void HoldMayo()
        {
            Mayo = false;
        }
    }
}

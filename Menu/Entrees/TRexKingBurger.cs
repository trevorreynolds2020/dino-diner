using System.Collections.Generic;


namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree
    {

        public bool Bun = true;
        public bool Lettuce = true;
        public bool Tomato = true;
        public bool Onion = true;
        public bool Pickle = true;
        public bool Ketchup = true;
        public bool Mustard = true;
        public bool Mayo = true;
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" , "Steakburger Pattie", "Steakburger Pattie" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Lettuce) ingredients.Add("Lettuce");
                if (Tomato) ingredients.Add("Tomato");
                if (Onion) ingredients.Add("Onion");
                if (Pickle) ingredients.Add("Pickle");
                if (Mustard) ingredients.Add("Mustard");
                if (Mayo) ingredients.Add("Mayo");
                if (Ketchup) ingredients.Add("Ketchup");
                return ingredients;
            }
        }

        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;
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
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}

using System.Collections.Generic;


namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

        public bool Bun = true;
        public bool Peppers = true;
        public bool Onion = true;
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst"};
                if (Bun)  ingredients.Add("Whole Wheat Bun");
                if (Peppers) ingredients.Add("Peppers");
                if (Onion) ingredients.Add("Onion");
                return ingredients;
            }
        }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void HoldBun()
        {
            Bun = false;
        }

        public void HoldPeppers()
        {
            Peppers = false;
        }
        public void HoldOnion()
        {
            Onion = false;
        }
    }
}

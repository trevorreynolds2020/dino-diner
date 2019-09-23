using System.Collections.Generic;


namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst : Entree
    {
        public bool Bun = true;
        public bool Peppers = true;
        public bool Onion = true;
        
        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;
            Ingredients.Add("Bratwurst");
            if (Bun) Ingredients.Add("Whole Wheat Bun");
            if (Peppers) Ingredients.Add("Peppers");
            if (Onion) Ingredients.Add("Onion");
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

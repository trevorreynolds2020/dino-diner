using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class PlesiousaurusPattie : Entree
    {
        private bool mayo = true;
        private bool bun = true;
        public override double Price
        {
            get
            {
                return 5.50;
            }
        }

        public override uint Calories { get { return 487; }   }
        
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Fish Patty");
                if(bun)ingredients.Add("Whole Wheat Bun");
                if(mayo)ingredients.Add("Mayonnaise");
                return ingredients;
            }
        }

        public override string Description => throw new NotImplementedException(); // change at some point

        public override string[] Special => throw new NotImplementedException();

        public PlesiousaurusPattie()
        {
            mayo = true;
            bun = true;
            Price = 5.5;
            Calories = 487;
        }

        public void HoldMayo()
        {
            mayo = false;
        }
        public void HoldBun()
        {
            bun = false;
        }
    }
}

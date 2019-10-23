using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class PlesiousaurusPattie : Entree
    {
        /// <summary>
        /// Indicates whether or not to include mayo
        /// </summary>
        private bool mayo = true;
        /// <summary>
        /// Indicates whether or not to include bun
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Gets price
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.50;
            }
        }
        /// <summary>
        /// Gets calories
        /// </summary>
        public override uint Calories { get { return 487; }   }
        /// <summary>
        /// Stores ingredients
        /// </summary>
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
        /// <summary>
        /// Constructs an instance of pattie
        /// </summary>
        public PlesiousaurusPattie()
        {
            mayo = true;
            bun = true;
            Price = 5.5;
            Calories = 487;
        }
        /// <summary>
        /// Doesn't include the mayo
        /// </summary>
        public void HoldMayo()
        {
            mayo = false;
        }
        /// <summary>
        /// Don't include the bun
        /// </summary>
        public void HoldBun()
        {
            bun = false;
        }
    }
}

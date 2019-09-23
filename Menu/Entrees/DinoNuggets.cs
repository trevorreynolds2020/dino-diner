using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// Number of chicken nuggets
        /// </summary>
        public uint count = 6;

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < count; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            Price = 4.25;
            Calories = 59*6;
        }

        public void AddNugget()
        {
            Price += .25;
            Calories += 59;
            count++;
        }
    }
}
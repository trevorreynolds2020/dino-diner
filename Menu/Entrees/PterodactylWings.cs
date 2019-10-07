using System.Collections.Generic;


namespace DinoDiner.Menu
{
    public class PterodactylWings : Entree
    {

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
        }

        public override string ToString()
        {
            return "Pterodactyl Wings";
        }

    }
}

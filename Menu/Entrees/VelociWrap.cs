using System.Collections.Generic;


namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

        public bool Dressing = true;
        public bool Lettuce = true;
        public bool Cheese = true;
       
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken Breast", "Flour Tortilla"};
                if (Dressing) ingredients.Add("Ceasar Dressing");
                if (Lettuce) ingredients.Add("Romaine Lettuce");
                if (Cheese) ingredients.Add("Parmesan Cheese");
               
                return ingredients;
            }
        }

        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        public void HoldDressing()
        {
            Dressing = false;
        }

        public void HoldCheese()
        {
            Cheese = false;
        }
        public void HoldLettuce()
        {
            Lettuce = false;
        }
       
    }
}

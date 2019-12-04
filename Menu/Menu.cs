using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    public class Menu
    {
        /// <summary>
        /// Gets all available items
        /// </summary>

        public HashSet<string> PossibleIngredients = new HashSet<string>();
        public List<IMenuItem> AvailableMenuItems { get; } = new List<IMenuItem>()
        {
            new Brontowurst(),
            new DinoNuggets(),
            new PrehistoricPBJ(),
            new PterodactylWings(),
            new SteakosaurusBurger(),
            new TRexKingBurger(),
            new VelociWrap(),
            new Fryceritops(),
            new MeteorMacAndCheese(),
            new MezzorellaSticks(),
            new Triceritots(),
            new JurassicJava(),
            new Sodasaurus(),
            new Tyrannotea(),
            new Water(),
            new CretaceousCombo(new Brontowurst()),
            new CretaceousCombo(new DinoNuggets()),
            new CretaceousCombo(new PrehistoricPBJ()),
            new CretaceousCombo(new PterodactylWings()),
            new CretaceousCombo(new SteakosaurusBurger()),
            new CretaceousCombo(new TRexKingBurger()),
            new CretaceousCombo(new VelociWrap())
        };

        /// <summary>
        /// Gets all available entrees
        /// </summary>
        public List<IMenuItem> AvailableEntrees { get; } = new List<IMenuItem>()
        {
            new Brontowurst(),
            new DinoNuggets(),
            new PrehistoricPBJ(),
            new PterodactylWings(),
            new SteakosaurusBurger(),
            new TRexKingBurger(),
            new VelociWrap()
        };
        /// <summary>
        /// Gets all available sides
        /// </summary>
        public List<IMenuItem> AvailableSides { get; } = new List<IMenuItem>()
        {

                new Fryceritops(),
                new MeteorMacAndCheese(),
                new MezzorellaSticks(),
                new Triceritots()
        };
        /// <summary>
        /// /Gets all available drinks
        /// </summary>
        public List<IMenuItem> AvailableDrinks { get; } = new List<IMenuItem>()
        {
            new JurassicJava(),
            new Sodasaurus(),
            new Tyrannotea(),
            new Water()
        };
        /// <summary>
        /// Gets all available combos
        /// </summary>
        public List<IMenuItem> AvailableCombos { get; } = new List<IMenuItem>()
        {
            new CretaceousCombo(new Brontowurst()),
            new CretaceousCombo(new DinoNuggets()),
            new CretaceousCombo(new PrehistoricPBJ()),
            new CretaceousCombo(new PterodactylWings()),
            new CretaceousCombo(new SteakosaurusBurger()),
            new CretaceousCombo(new TRexKingBurger()),
            new CretaceousCombo(new VelociWrap())
        };
        /// <summary>
        /// Returns all available items as one continuous string 
        /// </summary>
        /// <returns> all items as string </returns>
        public override string ToString()
        {
            for (int i = 0; i <= AvailableMenuItems.Count; i++)
            {
                return AvailableMenuItems[i].ToString() + " \n";
            }
            return "";
        }
        /// <summary>
        /// filters the ingredients
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="ingredients"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByIngredients(List<IMenuItem> menu, List<string> ingredients)
        {
            List<IMenuItem> searchResults = new List<IMenuItem>();
            for (int i = 0; i < menu.Count; i++)
            {
                bool keepItem = true;
                for (int j = 0; j < ingredients.Count; j++)
                {
                    if (menu[i].Ingredients.Contains(ingredients[j]))
                    {
                        keepItem = false;
                        menu.Remove(menu[i]);
                    }
                }
                if (keepItem)searchResults.Add(menu[i]);
            }
            return searchResults;
        }
    

        /// <summary>
        /// Filters items that cost less than max price range
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="maxPrice"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterMaxPrice(List<IMenuItem> menu, double? maxPrice)
        {
            List<IMenuItem> searchResults = new List<IMenuItem>();
            foreach (IMenuItem menuItem in menu)
            {
                if (menuItem.Price <= maxPrice)
                {
                    searchResults.Add(menuItem);
                }
            }
            return searchResults;
        }
        /// <summary>
        /// Keep items that are worth more than this price
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="minPrice"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterMinPrice(List<IMenuItem> menu, double? minPrice)
        {
            List<IMenuItem> searchResults = new List<IMenuItem>();
            foreach (IMenuItem menuItem in menu)
            {
                if (minPrice <= menuItem.Price)
                {
                    searchResults.Add(menuItem);
                }
            }
            return searchResults;
        }
        /// <summary>
        /// Returns all the possible ingredients
        /// </summary>
        /// <param name="Items"></param>
        public void AllIngredients(List<IMenuItem> Items)
        {
            foreach (IMenuItem item in Items)
            {
                foreach (string ingredient in item.Ingredients)
                {
                    PossibleIngredients.Add(ingredient);
                }
            }
        }
        /// <summary>
        /// Returns search result
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public List<IMenuItem> Search(List<IMenuItem> menu, string s)
        {
            List<IMenuItem> searchResult = new List<IMenuItem>();
            foreach (IMenuItem item in menu)
            {
                if (item.ToString().Contains(s))
                {
                    searchResult.Add(item);
                }
            }
            return searchResult;
        }
        /// <summary>
        /// Filters items based on large category
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="filters"></param>
        /// <returns></returns>
        public List<IMenuItem> Filter(List<IMenuItem> menu, List<string> filters)
        {
            List<IMenuItem> searchResult = new List<IMenuItem>();
            foreach (IMenuItem item in menu)
            {
                if (item is Drink && filters.Contains("Drink"))
                {
                    searchResult.Add(item);
                }
                if (item is Entree && filters.Contains("Entree"))
                {
                    searchResult.Add(item);
                }
                if (item is Side && filters.Contains("Side"))
                {
                    searchResult.Add(item);
                }
                if (item is CretaceousCombo && filters.Contains("Combo"))
                {
                    searchResult.Add(item);
                }
            }
            return searchResult;
        }
        
    }
}

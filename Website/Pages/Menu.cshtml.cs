using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;
namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// New instance of menu class
        /// </summary>
        public Menu Menu { get; } = new Menu();
        /// <summary>
        /// List of menu items
        /// </summary>
        public List<IMenuItem> MenuItems;
        /// <summary>
        /// List of combos
        /// </summary>
        public List<IMenuItem> Combos { get; set; }
        /// <summary>
        /// List of entrees
        /// </summary>
        public List<IMenuItem> Entrees { get; set; }
        /// <summary>
        /// List of sides
        /// </summary>
        public List<IMenuItem> Sides { get; set; }
        /// <summary>
        /// List of drinks
        /// </summary>
        public List<IMenuItem> Drinks { get; set; }
        /// <summary>
        /// Represents what your searching for
        /// </summary>
        [BindProperty]
        public String Search { get; set; }
        /// <summary>
        /// Minimum price on the item
        /// </summary>
        [BindProperty]
        public double? minPrice { get; set; }
        /// <summary>
        /// Maximum price of the item
        /// </summary>
        [BindProperty]
        public double? maxPrice { get; set; }
        /// <summary>
        /// List of filters applied to search
        /// </summary>
        [BindProperty]
        public List<string> Filter { get; set; } = new List<string>();
        /// <summary>
        /// List of ingredients
        /// </summary>
        [BindProperty]
        public List<string> Ingredients { get; set; } = new List<string>();
        /// <summary>
        /// List of ingredients
        /// </summary>
        public HashSet<string> IngredientHashSet { get; set; } = new HashSet<string>();
        /// <summary>
        /// When this is initally run
        /// </summary>
        public void OnGet()
        {
            Drinks = Menu.AvailableDrinks;
            Entrees = Menu.AvailableEntrees;
            Sides = Menu.AvailableSides;
            MenuItems = Menu.AvailableMenuItems;
            Combos = Menu.AvailableCombos;
            Menu.AllIngredients(Drinks);
            Menu.AllIngredients(Entrees);
            Menu.AllIngredients(Sides);
            Menu.AllIngredients(Combos);
            IngredientHashSet = Menu.PossibleIngredients;
        }
        /// <summary>
        /// When this is updated
        /// </summary>
        public void OnPost()
        {
            Drinks = Menu.AvailableDrinks;
            Entrees = Menu.AvailableEntrees;
            Sides = Menu.AvailableSides;
            MenuItems = Menu.AvailableMenuItems;
            Combos = Menu.AvailableCombos;
            Menu.AllIngredients(Drinks);
            Menu.AllIngredients(Entrees);
            Menu.AllIngredients(Sides);
            Menu.AllIngredients(Combos);
            IngredientHashSet = Menu.PossibleIngredients;

            if (minPrice != null)
            {
                Combos = Menu.FilterMinPrice(Combos, minPrice);
                Entrees = Menu.FilterMinPrice(Entrees, minPrice);
                Sides = Menu.FilterMinPrice(Sides, minPrice);
                Drinks = Menu.FilterMinPrice(Drinks, minPrice);
            }
            if (maxPrice != null)
            {
                Combos = Menu.FilterMaxPrice(Combos, maxPrice);
                Entrees = Menu.FilterMaxPrice(Entrees, maxPrice);
                Sides = Menu.FilterMaxPrice(Sides, maxPrice);
                Drinks = Menu.FilterMaxPrice(Drinks, maxPrice);
            }
            if (Search != null)
            {
                Combos = Menu.Search(Combos, Search);
                Entrees = Menu.Search(Entrees, Search);
                Sides = Menu.Search(Sides, Search);
                Drinks = Menu.Search(Drinks, Search);
            }
            if (Filter.Count != 0)
            {
                Combos = Menu.Filter(Combos, Filter);
                Entrees = Menu.Filter(Entrees, Filter);
                Sides = Menu.Filter(Sides, Filter);
                Drinks = Menu.Filter(Drinks, Filter);
            }
            if (Ingredients.Count != 0)
            {
                Combos = Menu.FilterByIngredients(Combos, Ingredients);
                Entrees = Menu.FilterByIngredients(Entrees, Ingredients);
                Sides = Menu.FilterByIngredients(Sides, Ingredients);
                Drinks = Menu.FilterByIngredients(Drinks, Ingredients);
            }
        }
    }
}
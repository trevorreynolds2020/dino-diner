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
        public Menu Menu { get; } = new Menu();

        public List<IMenuItem> MenuItems;
        public List<IMenuItem> Combos { get; set; }
        public List<IMenuItem> Entrees { get; set; }
        public List<IMenuItem> Sides { get; set; }
        public List<IMenuItem> Drinks { get; set; }

        [BindProperty]
        public String Search { get; set; }

        [BindProperty]
        public double? minPrice { get; set; }

        [BindProperty]
        public double? maxPrice { get; set; }

        [BindProperty]
        public List<string> Filter { get; set; } = new List<string>();

        [BindProperty]
        public List<string> Ingredients { get; set; } = new List<string>();

        public HashSet<string> IngredientHashSet { get; set; } = new HashSet<string>();


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
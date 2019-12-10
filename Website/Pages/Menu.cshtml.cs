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
        public IEnumerable<IMenuItem> MenuItems;
        /// <summary>
        /// List of combos
        /// </summary>
        public IEnumerable<IMenuItem> Combos { get; set; }
        /// <summary>
        /// List of entrees
        /// </summary>
        public IEnumerable<IMenuItem> Entrees { get; set; }
        /// <summary>
        /// List of sides
        /// </summary>
        public IEnumerable<IMenuItem> Sides { get; set; }
        /// <summary>
        /// List of drinks
        /// </summary>
        public IEnumerable<IMenuItem> Drinks { get; set; }
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
            Menu.AllIngredients(Menu.AvailableCombos);
            Menu.AllIngredients(Menu.AvailableEntrees);
            Menu.AllIngredients(Menu.AvailableDrinks);
            Menu.AllIngredients(Menu.AvailableSides);
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
            Menu.AllIngredients(Menu.AvailableCombos);
            Menu.AllIngredients(Menu.AvailableEntrees);
            Menu.AllIngredients(Menu.AvailableDrinks);
            Menu.AllIngredients(Menu.AvailableSides);
            IngredientHashSet = Menu.PossibleIngredients;

            if (minPrice != null)
            {
                Sides = Sides.Where(side => side.Price >= minPrice);
                Drinks = Drinks.Where(drink => drink.Price >= minPrice);
                Combos = Combos.Where(combo => combo.Price >= minPrice);
                Entrees = Entrees.Where(entree => entree.Price >= minPrice);
            }
            if (maxPrice != null)
            {
                Combos = Combos.Where(combo => combo.Price <= maxPrice);
                Drinks = Drinks.Where(drink => drink.Price <= maxPrice);
                Entrees = Entrees.Where(entree => entree.Price <= maxPrice);
                Sides = Sides.Where(side => side.Price <= maxPrice);

            }
            if (Search != null)
            {
                Combos = Combos.Where(combo => combo.ToString().Contains(Search));
                Sides = Sides.Where(side => side.ToString().Contains(Search));
                Entrees = Entrees.Where(entree => entree.ToString().Contains(Search));
                Drinks = Drinks.Where(drink => drink.ToString().Contains(Search));

            }
            if (Filter.Count != 0)
            {
                Combos = Combos.Where(combo => combo is CretaceousCombo && Filter.Contains("Combo"));
                Entrees = Entrees.Where(entree => entree is Entree && Filter.Contains("Entree"));
                Sides = Sides.Where(side => side is Side && Filter.Contains("Side"));
                Drinks = Drinks.Where(drink => drink is Drink && Filter.Contains("Drink"));
            }
            if (Ingredients.Count != 0)
            {
                Entrees = Entrees.Where(entree =>
                {
                    List<IMenuItem> searchResults = new List<IMenuItem>();
                    bool keepItem = true;
                    for (int i = 0; i < Ingredients.Count; i++)
                    {
                        if (entree.Ingredients.Contains(Ingredients[i]))
                        {
                            keepItem = false;
                        }
                    }
                    return keepItem;
                });

                Drinks = Drinks.Where(drink =>
                {
                    List<IMenuItem> searchResults = new List<IMenuItem>();
                    bool keepItem = true;
                    for (int i = 0; i < Ingredients.Count; i++)
                    {
                        if (drink.Ingredients.Contains(Ingredients[i]))
                        {
                            keepItem = false;
                            break;
                        }
                    }
                    return keepItem;
                });

                Sides = Sides.Where(side =>
                {
                    List<IMenuItem> searchResults = new List<IMenuItem>();
                    bool keepItem = true;
                    for (int i = 0; i < Ingredients.Count; i++)
                    {
                        if (side.Ingredients.Contains(Ingredients[i]))
                        {
                            keepItem = false;
                        }
                    }
                    return keepItem;
                });

                Combos = Combos.Where(combo =>
                {
                    List<IMenuItem> searchResults = new List<IMenuItem>();
                    bool keepItem = true;
                    for (int i = 0; i < Ingredients.Count; i++)
                    {
                        if (combo.Ingredients.Contains(Ingredients[i]))
                        {
                            keepItem = false;
                        }
                    }
                    return keepItem;
                });
            }
        }
    }
}
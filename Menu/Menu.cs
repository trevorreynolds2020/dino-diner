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
    }
}

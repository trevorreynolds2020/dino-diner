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

        private List<IMenuItem> availableMenuItems;
        private List<IMenuItem> availableEntrees;
        private List<IMenuItem> availableSides;
        private List<IMenuItem> availableCombos;
        private List<IMenuItem> availableDrinks;
        public List<IMenuItem> AvailableMenuItems
       {
            get
            {
                availableMenuItems.Add(new JurassicJava());
                availableMenuItems.Add(new Sodasaurus());
                availableMenuItems.Add(new Tyrannotea());
                availableMenuItems.Add(new Water());
                availableMenuItems.Add(new Brontowurst());
                availableMenuItems.Add(new DinoNuggets());
                availableMenuItems.Add(new PrehistoricPBJ());
                availableMenuItems.Add(new PterodactylWings());
                availableMenuItems.Add(new SteakosaurusBurger());
                availableMenuItems.Add(new TRexKingBurger());
                availableMenuItems.Add(new VelociWrap());
                availableMenuItems.Add(new PterodactylWings());
                availableMenuItems.Add(new Fryceritops());
                availableMenuItems.Add(new MeteorMacAndCheese());
                availableMenuItems.Add(new MezzorellaSticks());
                availableMenuItems.Add(new Triceritots());
                availableMenuItems.Add(new CretaceousCombo(new Brontowurst()));
                availableMenuItems.Add(new CretaceousCombo(new DinoNuggets()));
                availableMenuItems.Add(new CretaceousCombo(new PrehistoricPBJ()));
                availableMenuItems.Add(new CretaceousCombo(new PterodactylWings()));
                availableMenuItems.Add(new CretaceousCombo(new SteakosaurusBurger()));
                availableMenuItems.Add(new CretaceousCombo(new TRexKingBurger()));
                availableMenuItems.Add(new CretaceousCombo(new VelociWrap()));
                return availableMenuItems;
            }
       }
        /// <summary>
        /// Gets all available entrees
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                availableEntrees.Add(new Brontowurst());
                availableEntrees.Add(new DinoNuggets());
                availableEntrees.Add(new PrehistoricPBJ());
                availableEntrees.Add(new PterodactylWings());
                availableEntrees.Add(new SteakosaurusBurger());
                availableEntrees.Add(new TRexKingBurger());
                availableEntrees.Add(new VelociWrap());
                return availableEntrees;
            }
        }
        /// <summary>
        /// Gets all available sides
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                availableSides.Add(new Fryceritops());
                availableSides.Add(new MeteorMacAndCheese());
                availableSides.Add(new MezzorellaSticks());
                availableSides.Add(new Triceritots());
                return availableSides;
            }
        }
        /// <summary>
        /// /Gets all available drinks
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                availableDrinks.Add(new JurassicJava());
                availableDrinks.Add(new Sodasaurus());
                availableDrinks.Add(new Tyrannotea());
                availableDrinks.Add(new Water());
                return availableDrinks;
            }
        }
        /// <summary>
        /// Gets all available combos
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                availableCombos.Add(new CretaceousCombo(new Brontowurst()));
                availableCombos.Add(new CretaceousCombo(new DinoNuggets()));
                availableCombos.Add(new CretaceousCombo(new PrehistoricPBJ()));
                availableCombos.Add(new CretaceousCombo(new PterodactylWings()));
                availableCombos.Add(new CretaceousCombo(new SteakosaurusBurger()));
                availableCombos.Add(new CretaceousCombo(new TRexKingBurger()));
                availableCombos.Add(new CretaceousCombo(new VelociWrap()));
                return availableCombos
;
            }
        }
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

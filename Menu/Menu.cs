using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    public class Menu
    {
       public List<IMenuItem> AvailableMenuItems
       {
            get
            {     
                AvailableMenuItems.Add(new JurassicJava());
                AvailableMenuItems.Add(new Sodasaurus());
                AvailableMenuItems.Add(new Tyrannotea());
                AvailableMenuItems.Add(new Water());
                AvailableMenuItems.Add(new Brontowurst());
                AvailableMenuItems.Add(new DinoNuggets());
                AvailableMenuItems.Add(new PrehistoricPBJ());
                AvailableMenuItems.Add(new PterodactylWings());
                AvailableMenuItems.Add(new SteakosaurusBurger());
                AvailableMenuItems.Add(new TRexKingBurger());
                AvailableMenuItems.Add(new VelociWrap());
                AvailableMenuItems.Add(new PterodactylWings());
                AvailableMenuItems.Add(new Fryceritops());
                AvailableMenuItems.Add(new MeteorMacAndCheese());
                AvailableMenuItems.Add(new MezzorellaSticks());
                AvailableMenuItems.Add(new Triceritots());
                AvailableMenuItems.Add(new CretaceousCombo(new Brontowurst()));
                AvailableMenuItems.Add(new CretaceousCombo(new DinoNuggets()));
                AvailableMenuItems.Add(new CretaceousCombo(new PrehistoricPBJ()));
                AvailableMenuItems.Add(new CretaceousCombo(new PterodactylWings()));
                AvailableMenuItems.Add(new CretaceousCombo(new SteakosaurusBurger()));
                AvailableMenuItems.Add(new CretaceousCombo(new TRexKingBurger()));
                AvailableMenuItems.Add(new CretaceousCombo(new VelociWrap()));
                return AvailableMenuItems;
            }
       }

        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                AvailableEntrees.Add(new Brontowurst());
                AvailableEntrees.Add(new DinoNuggets());
                AvailableEntrees.Add(new PrehistoricPBJ());
                AvailableEntrees.Add(new PterodactylWings());
                AvailableEntrees.Add(new SteakosaurusBurger());
                AvailableEntrees.Add(new TRexKingBurger());
                AvailableEntrees.Add(new VelociWrap());
                return AvailableEntrees;
            }
        }

        public List<IMenuItem> AvailableSides
        {
            get
            {
                AvailableSides.Add(new Fryceritops());
                AvailableSides.Add(new MeteorMacAndCheese());
                AvailableSides.Add(new MezzorellaSticks());
                AvailableSides.Add(new Triceritots());
                return AvailableSides;
            }
        }
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                AvailableDrinks.Add(new JurassicJava());
                AvailableDrinks.Add(new Sodasaurus());
                AvailableDrinks.Add(new Tyrannotea());
                AvailableDrinks.Add(new Water());
                return AvailableDrinks;
            }
        }

        public List<IMenuItem> AvailableCombos
        {
            get
            {
                AvailableCombos.Add(new CretaceousCombo(new Brontowurst()));
                AvailableCombos.Add(new CretaceousCombo(new DinoNuggets()));
                AvailableCombos.Add(new CretaceousCombo(new PrehistoricPBJ()));
                AvailableCombos.Add(new CretaceousCombo(new PterodactylWings()));
                AvailableCombos.Add(new CretaceousCombo(new SteakosaurusBurger()));
                AvailableCombos.Add(new CretaceousCombo(new TRexKingBurger()));
                AvailableCombos.Add(new CretaceousCombo(new VelociWrap()));
                return AvailableCombos;
            }
        }

        public override string ToString()
        {
            return "s";
        }
    }
}

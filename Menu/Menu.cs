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
                AvailableMenuItems.Add(new JurrasicJava());
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
                return AvailableMenuItems;
            }
       }
    }
}

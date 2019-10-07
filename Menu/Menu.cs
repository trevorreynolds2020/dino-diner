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
                return AvailableMenuItems;
            }
       }
    }
}

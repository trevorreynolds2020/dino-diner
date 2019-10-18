using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class PterodactylWings : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// An event handler for PropertChanged events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Calls PropertChangedEventHandler if a specific property changes
        /// </summary>
        /// <param name="propertyName"></param>
        protected void INotifyIfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
        }

        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
        /// <summary>
        /// Gets a description of the order item
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Special order instructions
        /// if no special instructions return an empty array
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
               // if (!peanutButter) special.Add("Hold Peanut Butter");
                return special.ToArray();
            }
        }
    }
}

using System.Collections.Generic;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Brontowurst : Entree, INotifyPropertyChanged, IOrderItem
    {
        
        /// <summary>
        /// Indicates whether or not to include bun
        /// </summary>
        public bool Bun = true;
        /// <summary>
        /// Indicates whether or not to include peppers
        /// </summary>
        public bool Peppers = true;
        /// <summary>
        /// Indicates whether or not to include onion
        /// </summary>
        public bool Onion = true;

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
        /// <summary>
        /// Contains all the ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst"};
                if (Bun)  ingredients.Add("Whole Wheat Bun");
                if (Peppers) ingredients.Add("Peppers");
                if (Onion) ingredients.Add("Onion");
                return ingredients;
            }
        }
        /// <summary>
        /// Creates an instance of brontowurst
        /// </summary>
        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;
        }
        /// <summary>
        /// Don't use bun
        /// </summary>
        public void HoldBun()
        {
            Bun = false;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Don't use peppers
        /// </summary>
        public void HoldPeppers()
        {
            Peppers = false;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Don't use onion
        /// </summary>
        public void HoldOnion()
        {
            Onion = false;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Returns brontowurst - the string name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Brontowurst";
        }

        /// <summary>
        /// Gets a description of the order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// Special order instructions
        /// if no special instructions return an empty array
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Bun) special.Add("Hold Bun");
                if (!Onion) special.Add("Hold Onions");
                if (!Peppers) special.Add("Hold Peppers");
                return special.ToArray();
            }
        }

    }
}

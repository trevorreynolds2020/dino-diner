using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class SteakosaurusBurger : Entree, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Indicates whether or not to include bun
        /// </summary>
        public bool Bun = true;
        /// <summary>
        /// Indicates whether or not to include pickle
        /// </summary>
        public bool Pickle = true;
        /// <summary>
        /// Indicates whether or not to include ketchup
        /// </summary>
        public bool Ketchup = true;
        /// <summary>
        /// Indicates whether or not to include mustard
        /// </summary>
        public bool Mustard = true;


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
        /// List of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Pickle) ingredients.Add("Pickle");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }
        /// <summary>
        /// Creates an instance of burger
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }
        /// <summary>
        /// Holds bun
        /// </summary>
        public void HoldBun()
        {
            Bun = false;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Doesn't include pickle
        /// </summary>
        public void HoldPickle()
        {
            Pickle = false;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Don't use ketchup
        /// </summary>
        public void HoldKetchup()
        {
            Ketchup = false;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Doesn't include mustard
        /// </summary>
        public void HoldMustard()
        {
            Mustard = false;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Returns steakosaurus burger as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";

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
                if (!Pickle) special.Add("Hold Pickle");
                if (!Mustard) special.Add("Hold Mustard");
                if (!Ketchup) special.Add("Hold Ketchup");
                return special.ToArray();
            }
        }
    }
}

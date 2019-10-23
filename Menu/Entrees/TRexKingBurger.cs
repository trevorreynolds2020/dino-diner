using System.Collections.Generic;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree, INotifyPropertyChanged, IOrderItem
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
        /// <summary>
        /// Indicates whether or not to include bun
        /// </summary>
        public bool Bun = true;
        /// <summary>
        /// Indicates whether or not to include lettuce
        /// </summary>
        public bool Lettuce = true;
        /// <summary>
        /// Indicates whether or not to include tomato
        /// </summary>
        public bool Tomato = true;
        /// <summary>
        /// Indicates whether or not to include onion
        /// </summary>
        public bool Onion = true;
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
        /// Indicates whether or not to include mayo
        /// </summary>
        public bool Mayo = true;
        /// <summary>
        /// Stores ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" , "Steakburger Pattie", "Steakburger Pattie" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Lettuce) ingredients.Add("Lettuce");
                if (Tomato) ingredients.Add("Tomato");
                if (Onion) ingredients.Add("Onion");
                if (Pickle) ingredients.Add("Pickle");
                if (Mustard) ingredients.Add("Mustard");
                if (Mayo) ingredients.Add("Mayo");
                if (Ketchup) ingredients.Add("Ketchup");
                return ingredients;
            }
        }
        /// <summary>
        /// Creates an instance of burger
        /// </summary>
        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;
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
        /// Don't use lettuce
        /// </summary>
        public void HoldLettuce()
        {
            Lettuce = false;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Don't use tomato
        /// </summary>
        public void HoldTomato()
        {
            Tomato = false;
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
        /// Don't use pickle
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
        /// Don't use mustard
        /// </summary>
        public void HoldMustard()
        {
            Mustard = false;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Don't use mayo
        /// </summary>
        public void HoldMayo()
        {
            Mayo = false;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Returns burger name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
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
                if (!Lettuce) special.Add("Hold Lettuce");
                if (!Tomato) special.Add("Hold Tomato");
                if (!Onion) special.Add("Hold Onion");
                if (!Pickle) special.Add("Hold Pickle");
                if (!Mustard) special.Add("Hold Mustard");
                if (!Ketchup) special.Add("Hold Ketchup");
                if (!Mayo) special.Add("Hold Mayo");
                return special.ToArray();
            }
        }
    }
}

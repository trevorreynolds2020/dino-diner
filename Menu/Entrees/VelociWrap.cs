using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu

{
    public class VelociWrap : Entree, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Indicates whether or not to include dressing
        /// </summary>
        public bool Dressing = true;
        /// <summary>
        /// Indicates whether or not to include lettuce
        /// </summary>
        public bool Lettuce = true;
        /// <summary>
        /// Indicates whether or not to include cheese
        /// </summary>
        public bool Cheese = true;
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
        /// Stores ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken Breast", "Flour Tortilla"};
                if (Dressing) ingredients.Add("Ceasar Dressing");
                if (Lettuce) ingredients.Add("Romaine Lettuce");
                if (Cheese) ingredients.Add("Parmesan Cheese");              
                return ingredients;
            }
        }
        /// <summary>
        /// Constructs an instance of wrap
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
        }
        /// <summary>
        /// Don't use dressing
        /// </summary>
        public void HoldDressing()
        {
            Dressing = false;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Hold cheese
        /// </summary>
        public void HoldCheese()
        {
            Cheese = false;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Hold lettuce
        /// </summary>
        public void HoldLettuce()
        {
            Lettuce = false;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Returns name of entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
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
                if (!Cheese) special.Add("Hold Parmesan Cheese");
                if (!Lettuce) special.Add("Hold Romaine Lettuce");
                if (!Dressing) special.Add("Hold Ceasar Dressing");                        
                return special.ToArray();
            }
        }


    }
}

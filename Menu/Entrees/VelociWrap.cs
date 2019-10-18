using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu

{
    public class VelociWrap : Entree, INotifyPropertyChanged
    {

        public bool Dressing = true;
        public bool Lettuce = true;
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

        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
        }

        public void HoldDressing()
        {
            Dressing = false;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }

        public void HoldCheese()
        {
            Cheese = false;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        public void HoldLettuce()
        {
            Lettuce = false;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        public override string ToString()
        {
            return "Veloci-Wrap";
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
                if (!Dressing) special.Add("Hold Dressing");
                if (!Lettuce) special.Add("Hold Lettuce");
                if (!Cheese) special.Add("Hold Cheese");
                return special.ToArray();
            }
        }


    }
}

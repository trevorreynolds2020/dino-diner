using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Indicates whether or not to include peanut butter 
        /// </summary>
        private bool peanutButter = true;
        /// <summary>
        /// Indicates whether or not to include jelly
        /// </summary>
        private bool jelly = true;

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
        /// Ingredient list 
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructs an instance of pb&j
        /// </summary>
        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
        }
        /// <summary>
        /// Holds peanut butter
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Doesn't include jelly
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        /// <summary>
        /// Returns string for pb&j
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
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
                if (!peanutButter) special.Add("Hold Peanut Butter");
                if (!jelly) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }
    }
}

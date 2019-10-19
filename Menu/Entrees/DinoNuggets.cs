using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Number of chicken nuggets
        /// </summary>
        public uint count = 6;
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
                List<string> ingredients = new List<string>();
                for (int i = 0; i < count; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            Price = 4.25;
            Calories = 59*6;
        }

        public void AddNugget()
        {
            Price += .25;
            Calories += 59;
            count++;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }
        public override string ToString()
        {
            return "Dino-Nuggets";
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
                if (count > 6) special.Add((count - 6).ToString() + " Extra Nuggets");
                return special.ToArray();
            }
        }
    }
}
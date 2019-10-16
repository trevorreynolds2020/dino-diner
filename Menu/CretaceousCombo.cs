using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing a combo meal
    /// </summary>
    public class CretaceousCombo : IMenuItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void INotifyIfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private Entree entree;
        public Entree Entree
        {
            get { return entree; }
            protected set
            {
                entree = value;
                entree.PropertyChanged += (object sender, PropertyChangedEventArgs args)
                {
                    INotifyIfPropertyChanged(args.PropertyName);
                }
            }
        }
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }

        public string Description
        {
            get
            {
                return this.ToString();
            }
        }
        // Backing Variables
        private Size size;


        /// <summary>
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree { get; protected set; }

        /// <summary>
        /// Gets and sets the side
        /// </summary>
        public Side Side { get; set; } = new Fryceritops();

        private Drink drink = new Sodasaurus();
        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink
        { get { return drink; }
          set
          {
                INotifyIfPropertyChanged("Ingredients");
                INotifyIfPropertyChanged("Calories");
                INotifyIfPropertyChanged("Price");
                INotifyIfPropertyChanged("Special");
            }

        }

        /// <summary>
        /// Gets the price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// Gets the calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Gets or sets the size of the combo
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                //NotifyIfPropertyChanged("Size");
                INotifyIfPropertyChanged("Size");
                INotifyIfPropertyChanged("Special");
                INotifyIfPropertyChanged("Price");
                INotifyIfPropertyChanged("Calories");
            }
        }

        /// <summary>
        /// Gets the list of ingredients for the combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }


        /// <summary>
        /// Constructs a new combo with the specified entree
        /// </summary>
        /// <param name="entree">The entree to use</param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
        }
        public override string ToString()
        {
            return $"{Entree} Combo";
        }
    }
}

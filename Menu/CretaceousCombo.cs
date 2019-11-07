using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing a combo meal
    /// </summary>
    public class CretaceousCombo : Entree , IMenuItem, INotifyPropertyChanged, IOrderItem
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
        /// Backing variable for entree
        /// </summary>
        private Entree entree;
        /// <summary>
        /// /Gets the main dish
        /// </summary>
        public Entree Entree
        {
            get { return entree; }
            protected set
            {
                entree = value;
                entree.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    INotifyIfPropertyChanged(args.PropertyName);
                };
            }
        }
        /// <summary>
        /// Returns a list of special instructions
        /// </summary>
        public override string[] Special
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
        /// <summary>
        /// The description is the string representation of the entree
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        // Backing Variables
        private Size size;


        /// <summary>
        /// Gets and sets the side
        /// </summary>
        private Side side;
        public Side Side
        {
            get { return side; }
            set
            {
                this.side = value;
                this.side.Size = this.size;
                INotifyIfPropertyChanged("Ingredients");
                INotifyIfPropertyChanged("Special");
                INotifyIfPropertyChanged("Price");
                INotifyIfPropertyChanged("Calories");
            }
        }
        /// <summary>
        /// Backing variable for drink
        /// </summary>
        private Drink drink = new Sodasaurus();
        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink
        { get { return drink; }
          set
          {
                this.drink = value;
                this.drink.Size = this.size;
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
                INotifyIfPropertyChanged("Size");
                INotifyIfPropertyChanged("Special");
                INotifyIfPropertyChanged("Price");
                INotifyIfPropertyChanged("Calories");
                INotifyIfPropertyChanged("Description");
                INotifyIfPropertyChanged("Special");
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
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }
        /// <summary>
        /// Returns name of combo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Entree} Combo";
        }
    }
}

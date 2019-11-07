using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;
using DDSize = DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Single drink backing variable
        /// </summary>
        private Drink drink;
        /// <summary>
        /// Combo backing variable
        /// </summary>
        private CretaceousCombo combo;
        /// <summary>
        /// is it a combo?
        /// </summary>
        private bool isCombo;
        public DrinkSelection()
        {
            InitializeComponent();
        }
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
        }
        /// <summary>
        /// Constructor with the specific drink being selected
        /// </summary>
        /// <param name="drink"></param>
        public DrinkSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.isCombo = true;
            //this.drink = combo.Drink;
        }


        Button FlavorButton = new Button();
        Button LemonButton = new Button();
        Button SweetnerButton = new Button();
        Button HoldIce = new Button();
        Button RoomForCream = new Button();
        Button AddIce = new Button();
        Button Decaf = new Button();

       
        /// <summary>
        /// Handles drink click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SodasaurusClick(object sender, RoutedEventArgs args)
        {
            SodasurusButtonLogic();
        }
        /// <summary>
        /// Navigates to the flavor select screen when you choose flavor on soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void FlavorScreen(object sender, RoutedEventArgs args)
        {
            if(!isCombo)
            {
                Sodasaurus s = (Sodasaurus)drink;
                NavigationService.Navigate(new FlavorSelection(s));
            }
            else
            {
                if (combo.Drink is Sodasaurus soda)
                {
                    NavigationService.Navigate(new FlavorSelection(soda));

                }
            }
        }
        
        /// <summary>
        /// Handles drink click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void JurassicJavaClick(object sender, RoutedEventArgs args)
        {
             JurassicButtonLogic();           
        }
        
        /// <summary>
        /// Handles drink click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void WaterClick(object sender, RoutedEventArgs args)
        {
            WaterButtonLogic();
        }

        
        /// <summary>
        /// Handles drink click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void TyrannoteaClick(object sender, RoutedEventArgs args)
        {
            TyrannoteaButtonLogic();
        }
        void AddSweetner(object sender, RoutedEventArgs args)
        {
            // adds sweetner
        }
        /// <summary>
        /// Logic for the jurassic button - adds the right property change buttons
        /// </summary>
        void JurassicButtonLogic()
        {
            RemoveAllButtons();
            RoomForCream.Content = "Leave Room";
            AddIce.Content = "Add Ice";
            Decaf.Content = "Decaf";
            SelectDrink.Children.Add(RoomForCream);
            SelectDrink.Children.Add(AddIce);
            SelectDrink.Children.Add(Decaf);
            // checks it's in a combo 
            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                if(!isCombo)
                {
                    order.Add(drink);
                }
                else
                {
                    combo.Drink = drink;
                }
            }
            Decaf.Click += new RoutedEventHandler(OnDecafClick);
            AddIce.Click += new RoutedEventHandler(OnSelectAddIce);
            RoomForCream.Click += new RoutedEventHandler(OnRoomForCreamClick);
        }
        /// <summary>
        /// Logic for the water button - adds the right property change buttons
        /// </summary>
        void WaterButtonLogic()
        {
            RemoveAllButtons();
            AddIce.Content = "Add Ice";
            SelectDrink.Children.Add(AddIce);
            LemonButton.Content = "Add Lemon";
            SelectDrink.Children.Add(LemonButton);
            if (DataContext is Order order)
            {
                drink = new Water();
                if (!isCombo)
                {
                    order.Add(drink);
                }
                else
                {
                    combo.Drink = drink;
                }
            }
            AddIce.Click += new RoutedEventHandler(AddIceToWaterButtonClick);
            LemonButton.Click += new RoutedEventHandler(AddLemonToWaterButtonClick);
        }
        /// <summary>
        /// Logic for the tyrannotea button - adds the right property change buttons
        /// </summary>
        void TyrannoteaButtonLogic()
        {
            RemoveAllButtons();
            SweetnerButton.Content = "Add Sweetner";
            AddIce.Content = "Add Ice";
            LemonButton.Content = "Add Lemon";
            SelectDrink.Children.Add(LemonButton);
            SelectDrink.Children.Add(AddIce);
            SelectDrink.Children.Add(SweetnerButton);
            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                if (!isCombo)
                {
                    order.Add(drink);
                }
                else
                {
                    combo.Drink = drink;
                }
            }
            LemonButton.Click += new RoutedEventHandler(AddLemonToTyrannoteaButtonClick);
            AddIce.Click += new RoutedEventHandler(AddIceToTyrannoteaButtonClick);
            SweetnerButton.Click += new RoutedEventHandler(AddSweetnerToTyrannoteaButtonClick);
        }
        /// <summary>
        /// Logic for the sodasurus button - adds the right property change buttons
        /// </summary>
        void SodasurusButtonLogic()
        {
            RemoveAllButtons();
            FlavorButton.Content = "Flavor";
            SelectDrink.Children.Add(FlavorButton);
            FlavorButton.Click += new RoutedEventHandler(FlavorScreen);
            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                if (!isCombo)
                {
                    order.Add(drink);
                }
                else
                {
                    combo.Drink = drink;
                }
            }
        }
        /// <summary>
        /// Removes all button that handle special conditions on each item
        /// </summary>
        void RemoveAllButtons()
        {
            SelectDrink.Children.Remove(FlavorButton);
            SelectDrink.Children.Remove(LemonButton);
            SelectDrink.Children.Remove(SweetnerButton);
            SelectDrink.Children.Remove(HoldIce);
            SelectDrink.Children.Remove(RoomForCream);
            SelectDrink.Children.Remove(AddIce);
            SelectDrink.Children.Remove(Decaf);
        }
        /// <summary>
        /// Changes size of element object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if(!isCombo)
            {
                if (sender is FrameworkElement element)
                {
                    drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                }
            }
            else
            {
                if (sender is FrameworkElement element)
                {
                    combo.Drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                }
            }
        }
        
        /// <summary>
        /// Adds ice when the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectAddIce(object sender, RoutedEventArgs args)
        {
            if(!isCombo)
            {
                if (drink is JurassicJava java)
                {
                    java.AddIce();
                }
            }
            else
            {
                if (combo.Drink is JurassicJava java)
                {
                    java.AddIce();
                }
            }
        }
        /// <summary>
        /// Makes the coffee decaf when the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDecafClick(object sender, RoutedEventArgs args)
        {
            if(isCombo)
            {
                if (combo.Drink is JurassicJava java)
                {
                    java.DecafJava();
                }
            }
            else
            {
                if (drink is JurassicJava java)
                {
                    java.DecafJava();
                }
            }
        }
        /// <summary>
        /// Leaves room for cream on button click - event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnRoomForCreamClick(object sender, RoutedEventArgs args)
        {
            if(isCombo)
            {
                if(drink is JurassicJava java)
                {
                    java.LeaveRoomForCream();
                }
            }
            else
            {
                if (drink is JurassicJava java)
                {
                    java.LeaveRoomForCream();
                }
            }
            
        }
        /// <summary>
        /// Adds ice to water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AddIceToWaterButtonClick(object sender, RoutedEventArgs args)
        {
            if (!isCombo)
            {
                if (drink is Water water)
                {
                    water.Ice = true;
                }
            }
            else
            {
                if (combo.Drink is Water water)
                {
                    water.Ice = true;
                }
            }
        }
        /// <summary>
        /// Add lemon to water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AddLemonToWaterButtonClick(object sender, RoutedEventArgs args)
        {
            if(!isCombo)
            {
                if (drink is Water water)
                {
                    water.AddLemon();
                }
            }
            else
            {
                if (combo.Drink is Water water)
                {
                    water.AddLemon();
                }
            }
        }
        /// <summary>
        /// Adds ice to tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AddIceToTyrannoteaButtonClick(object sender, RoutedEventArgs args)
        {
            if(!isCombo)
            {
                if (drink is Tyrannotea tea)
                {
                    tea.Ice = true;
                }
            }
            else
            {
                if (combo.Drink is Tyrannotea tea)
                {
                    tea.Ice = true;
                }
            }
        }
        /// <summary>
        /// Add lemon to tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AddLemonToTyrannoteaButtonClick(object sender, RoutedEventArgs args)
        {
            if(!isCombo)
            {
                if (drink is Tyrannotea tea)
                {
                    tea.AddLemon();
                }
            }
            else
            {
                if (combo.Drink is Tyrannotea tea)
                {
                    tea.AddLemon();
                }
            }
        }
        /// <summary>
        /// Add sweetner to tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AddSweetnerToTyrannoteaButtonClick(object sender, RoutedEventArgs args)
        {
            if(!isCombo)
            {
                if (drink is Tyrannotea tea)
                {
                    tea.AddSweetner();
                }
            }
            else
            {
                if (combo.Drink is Tyrannotea tea)
                {
                    tea.AddSweetner();
                }
            }
        }
    }
}

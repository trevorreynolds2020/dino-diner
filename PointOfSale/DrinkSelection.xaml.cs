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
        private Drink drink;
        public DrinkSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor with the specific drink being selected
        /// </summary>
        /// <param name="drink"></param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
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
            RemoveAllButtons();
            FlavorButton.Content = "Flavor";
            SelectDrink.Children.Add(FlavorButton);
            FlavorButton.Click += new RoutedEventHandler(FlavorScreen);
            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                order.Add(drink);
            }

        }
        /// <summary>
        /// Navigates to the flavor select screen when you choose flavor on soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void FlavorScreen(object sender, RoutedEventArgs args)
        {
            Sodasaurus s = (Sodasaurus) drink;
            NavigationService.Navigate(new FlavorSelection(s));
        }
        /// <summary>
        /// Handles drink click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void JurassicJavaClick(object sender, RoutedEventArgs args)
        {
            RemoveAllButtons();
            RoomForCream.Content = "Leave Room";
            AddIce.Content = "Add Ice";
            Decaf.Content = "Decaf";
            SelectDrink.Children.Add(RoomForCream);
            SelectDrink.Children.Add(AddIce);
            SelectDrink.Children.Add(Decaf);
            //.Click += new RoutedEventHandler();
            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                order.Add(drink);
            }
            Decaf.Click += new RoutedEventHandler(OnDecafClick);
            AddIce.Click += new RoutedEventHandler(OnSelectAddIce);
            RoomForCream.Click += new RoutedEventHandler(OnRoomForCreamClick);

        }
        /// <summary>
        /// Handles drink click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void WaterClick(object sender, RoutedEventArgs args)
        {
            RemoveAllButtons();
            AddIce.Content = "Add Ice";
            SelectDrink.Children.Add(AddIce);
            LemonButton.Content = "Add Lemon";
            SelectDrink.Children.Add(LemonButton);
            //.Click += new RoutedEventHandler();
            if (DataContext is Order order)
            {
                drink = new Water();
                order.Add(drink);
            }
            AddIce.Click += new RoutedEventHandler(AddIceToWaterButtonClick);
            LemonButton.Click += new RoutedEventHandler(AddLemonToWaterButtonClick);
        }
        /// <summary>
        /// Handles drink click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void TyrannoteaClick(object sender, RoutedEventArgs args)
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
                order.Add(drink);
            }
            LemonButton.Click += new RoutedEventHandler(AddLemonToTyrannoteaButtonClick);
            AddIce.Click += new RoutedEventHandler(AddIceToTyrannoteaButtonClick);
            SweetnerButton.Click += new RoutedEventHandler(AddSweetnerToTyrannoteaButtonClick);
        }
        void AddSweetner(object sender, RoutedEventArgs args)
        {
            // adds sweetner
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
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }
        
        /// <summary>
        /// Adds ice when the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectAddIce(object sender, RoutedEventArgs args)
        {
            if (drink is JurassicJava java)
            {
                java.AddIce();
            }
        }
        /// <summary>
        /// Makes the coffee decaf when the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDecafClick(object sender, RoutedEventArgs args)
        {
            if (drink is JurassicJava java)
            {
                java.DecafJava();
            }
        }
        /// <summary>
        /// Leaves room for cream on button click - event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnRoomForCreamClick(object sender, RoutedEventArgs args)
        {
            if (drink is JurassicJava java)
            {
                java.LeaveRoomForCream();
            }
        }
        /// <summary>
        /// Adds ice to water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AddIceToWaterButtonClick(object sender, RoutedEventArgs args)
        {
            if (drink is Water water)
            {
                water.Ice = true;
            }
        }
        /// <summary>
        /// Add lemon to water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AddLemonToWaterButtonClick(object sender, RoutedEventArgs args)
        {
            if (drink is Water water)
            {
                water.AddLemon();
            }
        }
        /// <summary>
        /// Adds ice to tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AddIceToTyrannoteaButtonClick(object sender, RoutedEventArgs args)
        {
            if (drink is Tyrannotea tea)
            {
                tea.Ice = true;
            }
        }
        /// <summary>
        /// Add lemon to tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AddLemonToTyrannoteaButtonClick(object sender, RoutedEventArgs args)
        {
            if (drink is Tyrannotea tea)
            {
                tea.AddLemon();
            }
        }
        /// <summary>
        /// Add sweetner to tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AddSweetnerToTyrannoteaButtonClick(object sender, RoutedEventArgs args)
        {
            if (drink is Tyrannotea tea)
            {
                tea.AddSweetner();
            }
        }
    }
}

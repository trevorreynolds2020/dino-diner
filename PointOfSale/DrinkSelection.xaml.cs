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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
        }

        Button FlavorButton = new Button();
        Button LemonButton = new Button();
        Button SweetnerButton = new Button();
        Button HoldIce = new Button();
        Button RoomForCream = new Button();
        Button AddIce = new Button();
        Button Decaf = new Button();

        

        void SodasaurusClick(object sender, RoutedEventArgs args)
        {
            RemoveAllButtons();
            FlavorButton.Content = "Flavor";
            SelectDrink.Children.Add(FlavorButton);
            FlavorButton.Click += new RoutedEventHandler(FlavorScreen);
       
        }
        void FlavorScreen(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
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

        }
        
        void WaterClick(object sender, RoutedEventArgs args)
        {
            RemoveAllButtons();
            AddIce.Content = "Add Ice";
            SelectDrink.Children.Add(AddIce);
            //.Click += new RoutedEventHandler();
        }
        void TyrannoteaClick(object sender, RoutedEventArgs args)
        {
            RemoveAllButtons();
            SweetnerButton.Content = "Add Sweetner";
            AddIce.Content = "Add Ice";
            LemonButton.Content = "Add Lemon";
            SelectDrink.Children.Add(LemonButton);
            SelectDrink.Children.Add(AddIce);
            SelectDrink.Children.Add(SweetnerButton);

            //.Click += new RoutedEventHandler();
        }
        void AddSweetner(object sender, RoutedEventArgs args)
        {
            // adds sweetner
        }
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
        

    }
}

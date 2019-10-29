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
using DDFlavor = DinoDiner.Menu.SodasaurusFlavor;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        private Sodasaurus soda;
        private SodasaurusFlavor flavor;
        public FlavorSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor where you pass a Sodasaurus
        /// </summary>
        /// <param name="soda"></param>
        public FlavorSelection(Sodasaurus soda)
        {
            InitializeComponent();
            this.soda = soda;
        }
        /// <summary>
        /// Changes the flavor of the sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void CherryClick(object sender,RoutedEventArgs args)
        {
            if(soda is Sodasaurus s)
            {
                s.Flavor = SodasaurusFlavor.Cherry;
            }
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Changes the flavor of the sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ChocolateClick(object sender, RoutedEventArgs args)
        {
            if (soda is Sodasaurus s)
            {
                s.Flavor = SodasaurusFlavor.Chocolate;
            }
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Changes the flavor of the sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void VanillaClick(object sender, RoutedEventArgs args)
        {
            if (soda is Sodasaurus s)
            {
                s.Flavor = SodasaurusFlavor.Vanilla;
            }
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Changes the flavor of the sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void LimeClick(object sender, RoutedEventArgs args)
        {
            if (soda is Sodasaurus s)
            {
                s.Flavor = SodasaurusFlavor.Lime;
            }
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Changes the flavor of the sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OrangeClick(object sender, RoutedEventArgs args)
        {
            if (soda is Sodasaurus s)
            {
                s.Flavor = SodasaurusFlavor.Orange;
            }
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Changes the flavor of the sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ColaClick(object sender, RoutedEventArgs args)
        {
            if (soda is Sodasaurus s)
            {
                s.Flavor = SodasaurusFlavor.Cola;
            }
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Changes the flavor of the sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void RootBeerClick(object sender, RoutedEventArgs args)
        {
            if (soda is Sodasaurus s)
            {
                s.Flavor = SodasaurusFlavor.RootBeer;
            }
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}

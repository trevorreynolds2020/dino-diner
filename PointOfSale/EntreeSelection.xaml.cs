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
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        private Entree entree;
        public EntreeSelection()
        {
            InitializeComponent();
        }
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            this.entree = entree;
        }
        /// <summary>
        /// Adds entree to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBrontowurst(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new Brontowurst();
                order.Add(entree);
            }
        }
        /// <summary>
        /// Adds entree to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDinoNuggets(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new DinoNuggets();
                order.Add(entree);
            }
        }
        /// <summary>
        /// Adds entree to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectPrehistoricPBJ(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ entree = new PrehistoricPBJ(); // Note: explicitly state type when passing as a parameter to constructor
                order.Add(entree);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(entree));
            }
        }
        /// <summary>
        /// Adds entree to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectPterodactylWings(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Add(entree);
            }
        }
        /// <summary>
        /// Adds entree to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSteakosaurusBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new SteakosaurusBurger();
                order.Add(entree);
            }
        }
        /// <summary>
        /// Adds entree to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectTRexKingBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new TRexKingBurger();
                order.Add(entree);
            }
        }
        /// <summary>
        /// Adds entree to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectVelociWrap(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new VelociWrap();
                order.Add(entree);
            }
        }


    }
}

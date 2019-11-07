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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        private CretaceousCombo combo;
        public ComboSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// On entree click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PrehistoricPBJClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                CretaceousCombo combo = new CretaceousCombo(pbj);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeComboSelection(combo));
            }
        }
        /// <summary>
        /// On entree click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void BrontowurstClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst brot = new Brontowurst();
                CretaceousCombo combo = new CretaceousCombo(brot);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeComboSelection(combo));
            }
        }
        /// <summary>
        /// On entree click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void DinoNuggetsClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets nugs = new DinoNuggets();
                CretaceousCombo combo = new CretaceousCombo(nugs);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeComboSelection(combo));
            }
        }
        /// <summary>
        /// On entree click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PterodactylWingsClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PterodactylWings wings = new PterodactylWings();
                CretaceousCombo combo = new CretaceousCombo(wings);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeComboSelection(combo));
            }
        }
        /// <summary>
        /// On entree click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SteakosaurusBurgerClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger burger = new SteakosaurusBurger();
                CretaceousCombo combo = new CretaceousCombo(burger);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeComboSelection(combo));
            }
        }
        /// <summary>
        /// On entree click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void TRexKingBurgerClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger burger = new TRexKingBurger();
                CretaceousCombo combo = new CretaceousCombo(burger);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeComboSelection(combo));
            }
        }
        /// <summary>
        /// On entree click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void VelociWrapClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                VelociWrap wrap = new VelociWrap();
                CretaceousCombo combo = new CretaceousCombo(wrap);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeComboSelection(combo));
            }
        }
    }
}

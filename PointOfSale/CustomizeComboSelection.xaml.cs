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
    /// Interaction logic for CustomizeComboSelection.xaml
    /// </summary>
    public partial class CustomizeComboSelection : Page
    {
        /// <summary>
        /// Holds the current combo object
        /// </summary>
        private CretaceousCombo combo;
        void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(combo, true)); // yes, this is a combo TRUE
        }
        void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
        
        /// <summary>
        /// Passes in current combo object
        /// </summary>
        /// <param name="combo"></param>
        public CustomizeComboSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }
    }
}

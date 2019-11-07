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
        public CustomizeComboSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        void SelectEntree(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is PrehistoricPBJ pbj)
            {
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj, true));
            }
               
        }
        /// <summary>
        /// Checks the entree type from the selected combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectCombo(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is PrehistoricPBJ pbj)
            {
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj, true));
            }
        }
        void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(combo)); // yes, this is a combo TRUE
        }
        void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(combo));
        }
        
       
    }
}

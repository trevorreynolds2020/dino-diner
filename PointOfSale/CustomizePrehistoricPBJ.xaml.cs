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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        /// <summary>
        /// Private backing field for pbj object
        /// </summary>
        PrehistoricPBJ pbj; // Note: default for C# is private therefore this is private
        /// <summary>
        /// Determines if this entree apart of a combo
        /// </summary>
        private bool isCombo;
        /// <summary>
        /// Constructor for combo
        /// </summary>
        /// <param name="pbj"></param>
        /// <param name="isCombo"></param>
        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj, bool isCombo)
        {
            InitializeComponent();
            this.pbj = pbj;
            this.isCombo = isCombo;
            
        }
        /// <summary>
        /// For non combo
        /// </summary>
        public CustomizePrehistoricPBJ()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Holds the peanut butter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            pbj.HoldPeanutButter();
        }
        /// <summary>
        /// Holds the jelly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            pbj.HoldJelly();
        }
        /// <summary>
        /// When done is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (isCombo)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
               
        }
    }
}

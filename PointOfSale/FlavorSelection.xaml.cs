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
            this.soda = soda;
        }
        /// <summary>
        /// Changes the flavor of the sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void CherryClick(object sender,RoutedEventArgs args)
        {
            if(DataContext is Sodasaurus s)
            {
                s.Flavor = SodasaurusFlavor.Cherry;
            }
        }
        /// <summary>
        /// Changes the flavor of the sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ChocolateClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Sodasaurus s)
            {
                s.Flavor = SodasaurusFlavor.Chocolate;
            }
        }
        /// <summary>
        /// Changes size of element object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeFlavor(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                soda.Flavor = (DDFlavor)Enum.Parse(typeof(DDFlavor), element.Tag.ToString());
            }
        }
    }
}

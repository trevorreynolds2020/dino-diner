using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor - always creates a new order object and assigns it to DataContext
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Order order = new Order();
            DataContext = order;
            OrderUI.Navigate(new MenuCategorySelection());
            OrderInterface.NavigationService = OrderUI.NavigationService;
        }
        /// <summary>
        /// When the data is passed
        /// </summary>
        private void PassDataContent()
        {
            if (OrderUI.Content is Page page)
            {
                page.DataContext = OrderUI.DataContext;
            }

        }
        /// <summary>
        /// When the screen is successfully loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            PassDataContent();
        }
        /// <summary>
        /// When the data is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassDataContent();
        }
        /// <summary>
        /// Returns to category selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnReturnToCategorySelection(object sender, RoutedEventArgs args)
        {
            OrderInterface.NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}

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
        private CretaceousCombo PBJCombo;
        public CustomizePrehistoricPBJ(bool isCombo)
        {
            InitializeComponent();
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            this.pbj = pbj;
            this.isCombo = isCombo;
            //Creates a combo and add it to the menu
            if(isCombo)
            {
                CretaceousCombo PBJCombo = new CretaceousCombo(pbj);
                this.PBJCombo = PBJCombo;
                if (DataContext is Order order)
                {
                    order.Add(PBJCombo.Entree);  
                }
            }
            else
            {
                if (DataContext is Order order)
                {
                    order.Add(pbj);
                }
            }
        }
        /// <summary>
        /// Holds the peanut butter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            pbj.HoldPeanutButter();
            Console.WriteLine("hold peanut");
            string[] bleh = pbj.Special;
            for(int i = 0; i < bleh.Length; i++)
            {
                Console.WriteLine(bleh[i]);
            }
        }
        /// <summary>
        /// Holds the jelly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            pbj.HoldJelly();
            Console.WriteLine("hold jelly");
        }
        /// <summary>
        /// When done is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if(isCombo)
            {
                NavigationService.Navigate(new CustomizeComboSelection(PBJCombo));
            }
            else
            {
                NavigationService.GoBack();
            }
        }
    }
}

﻿using System;
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
        private bool combo;
        public EntreeSelection()
        {
            InitializeComponent();
        }
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            this.entree = entree;
        }
        public EntreeSelection(Entree entree, bool combo)
        {
            InitializeComponent();
            this.entree = entree;
            this.combo = combo;
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
                Brontowurst entree = new Brontowurst();
                order.Add(entree);
                NavigationService.Navigate(new CustomizeBrontowurst(entree));
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
                DinoNuggets entree = new DinoNuggets();
                order.Add(entree);
                NavigationService.Navigate(new CustomizeDinoNuggets(entree));
            }
        }
        /// <summary>
        /// Adds entree to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectPrehistoricPBJ(object sender, RoutedEventArgs e)
        {
            if(combo)
            {
                if (DataContext is Order)
                {
                    PrehistoricPBJ pbj = new PrehistoricPBJ();
                    //order.Add(pbj);
                    NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj,true));
                }
            }
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj,false));
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
            NavigationService.Navigate(new MenuCategorySelection());
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
                SteakosaurusBurger entree = new SteakosaurusBurger();
                order.Add(entree);
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(entree));
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
                TRexKingBurger entree = new TRexKingBurger();
                order.Add(entree);
                NavigationService.Navigate(new CustomizeTRexKingBurger(entree));
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
                VelociWrap entree = new VelociWrap();
                order.Add(entree);
                NavigationService.Navigate(new CustomizeVelociWrap(entree));
            }
            
        }


    }
}

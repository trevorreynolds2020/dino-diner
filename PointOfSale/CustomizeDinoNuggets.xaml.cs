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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        /// <summary>
        /// Private backing field for nuggets object
        /// </summary>
        DinoNuggets nugs;
        public CustomizeDinoNuggets(DinoNuggets nugs)
        {
            InitializeComponent();
            this.nugs = nugs;
        }
        /// <summary>
        /// Adds nugget
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnAddNugget(object sender, RoutedEventArgs args)
        {
            this.nugs.AddNugget();
        }
        /// <summary>
        /// When done is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
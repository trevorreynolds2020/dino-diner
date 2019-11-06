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
using DDSize = DinoDiner.Menu.Size;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// Private backing variable for the side chosen
        /// </summary>
        private Side side;
        /// <summary>
        /// Checks whether this is a side on a combo
        /// </summary>
        private bool isCombo;
        /// <summary>
        /// Backing variable for combo
        /// </summary>
        CretaceousCombo combo;
        public SideSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Checks for combo selection
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="isCombo"></param>
        public SideSelection(CretaceousCombo combo, bool isCombo)
        {
            InitializeComponent();
            this.combo = combo;
            this.isCombo = isCombo;
        }
        /// <summary>
        /// Constructs a Side Selection page by passing side object - that way we can edit this specific object
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }
        /// <summary>
        /// Adds side to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFryceritops(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                side = new Fryceritops();
                combo.Side = side;
                order.Add(combo);
            }
        }
        /// <summary>
        /// Adds side to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectMeteorMacAndCheese(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                order.Add(side);
            }
        }
        /// <summary>
        /// Adds side to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectMezzorellaSticks(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                side = new MezzorellaSticks();
                order.Add(side);
            }
        }
        /// <summary>
        /// Adds side to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectTriceritots(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                side = new Triceritots();
                order.Add(side);
            }
        }
        /// <summary>
        /// Changes size of element object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if(side == null)
            {
                return;
            }
            if (sender is FrameworkElement element)
            {
                side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }
    }
}

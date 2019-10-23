using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IOrderItem
    {
        /// <summary>
        /// Stores price
        /// </summary>
        double Price { get; }
        /// <summary>
        /// Stores name of item
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Stores special instructions
        /// </summary>
        string[] Special { get; }
    }
}

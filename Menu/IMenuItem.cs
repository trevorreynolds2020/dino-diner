using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IMenuItem
    {
        /// <summary>
        /// Stores price
        /// </summary>
        double Price { get; }
        /// <summary>
        /// Stores caloires
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// Stores ingredients
        /// </summary>
        List<string> Ingredients { get; }
    }
}

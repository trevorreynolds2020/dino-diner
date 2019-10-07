using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IMenuItem : Menu
    {
       double Price { get; }
       uint Calories { get; }
       List<string> Ingredients { get; }
    }
}

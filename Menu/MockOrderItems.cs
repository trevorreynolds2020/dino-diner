using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class MockOrderItems : IOrderItem
    {
        public string Description { get; set; }
        public double Price { get; set; }
        public string[] Special { get; set; }

        public class MockOrderItems1 : IOrderItem
        {
            public string Description { get; set; }
            public double Price { get; set; }
            public string[] Special { get; set; }
            public MockOrderItems1(double price)
            {
                Price = price;
            }
        }

        public class MockOrderItems2 : IOrderItem
        {
            public string Description { get; set; }
            public double Price { get; set; }
            public string[] Special { get; set; }
            public MockOrderItems2(double price)
            {
                Price = price;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class MockOrderItems : IOrderItem
    {
        /// <summary>
        /// Get/set description of order item
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Get/set price of order item
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Get/set special of order item
        /// </summary>
        public string[] Special { get; set; }
        /// <summary>
        /// First test order item
        /// </summary>
        public class MockOrderItems1 : IOrderItem
        {
            /// <summary>
            /// Get/set description of order item
            /// </summary>
            public string Description { get; set; }
            /// <summary>
            /// Get/set price of order item
            /// </summary>
            public double Price { get; set; }
            /// <summary>
            /// Get/set special of order item
            /// </summary>
            public string[] Special { get; set; }
            /// <summary>
            /// First test order item
            /// </summary>
            public MockOrderItems1(double price)
            {
                Price = price;
            }
        }
        /// <summary>
        /// Second test order item
        /// </summary>
        public class MockOrderItems2 : IOrderItem
        {
            /// <summary>
            /// Get/set description of order item
            /// </summary>
            public string Description { get; set; }
            /// <summary>
            /// Get/set price of order item
            /// </summary>
            public double Price { get; set; }
            /// <summary>
            /// Get/set special of order item
            /// </summary>
            public string[] Special { get; set; }
            /// <summary>
            /// First test order item
            /// </summary>
            public MockOrderItems2(double price)
            {
                Price = price;
            }
        }

    }
}

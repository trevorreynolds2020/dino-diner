using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
namespace MenuTest
{
    public class MockMenuItemTest
    {
        [Fact]
        public void SubTotalCostShouldBeAPositiveValue()
        {
            Order o = new Order();
            o.Add(new MockOrderItems.MockOrderItems1(5.0));
            o.Add(new MockOrderItems.MockOrderItems2(5.0));
            Assert.Equal<double>(10, o.SubtotalCost);
        }

        [Fact]
        public void SubTotalShouldNotBeANegativeValue()
        {
            Order o = new Order();
            o.Add(new MockOrderItems.MockOrderItems1(5.0));
            o.Add(new MockOrderItems.MockOrderItems2(-10.0));
            Assert.Equal<double>(0, o.SubtotalCost);
        }
    }
}

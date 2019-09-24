using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal(1.50, s.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal<uint>(112, s.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Contains<string>("Water", s.Ingredients);
            Assert.Contains<string>("Natural Flavor", s.Ingredients);
            Assert.Contains<string>("Cane Sugar", s.Ingredients);
            Assert.Equal<int>(3,s.Ingredients.Count);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, s.Size);
        }
    }
}

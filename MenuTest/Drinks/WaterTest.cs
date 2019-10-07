using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        [Fact]
        public void CaloriesForSmall()
        {
            Water w = new Water();
            w.Size = Size.Small;
            Assert.Equal<uint>(0, w.Calories);
        }
        [Fact]
        public void PriceForSmall()
        {
            Water w = new Water();
            w.Size = Size.Small;
            Assert.Equal<double>(.1, w.Price);
        }
        [Fact]
        public void CaloriesForMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<uint>(0, w.Calories);
        }
        [Fact]
        public void PriceForMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<double>(.1, w.Price);
        }
        [Fact]
        public void CaloriesForLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<uint>(0, w.Calories);
        }
        [Fact]
        public void PriceForLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<double>(.1, w.Price);
        }
        [Fact]
        public void ShouldHoldIce()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.False(w.Ice);
        }
        [Fact]
        public void ShouldAddLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.True(w.Lemon);
        }
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Water w = new Water();
            Assert.Contains<string>("Water", w.Ingredients);
            
            Assert.Equal<int>(1, w.Ingredients.Count);
        }
    }
}

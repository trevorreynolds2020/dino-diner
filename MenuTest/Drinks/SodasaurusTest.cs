using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus s = new Sodasaurus();
            s.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, s.Flavor);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Small;
            Assert.Equal<double>(1.50, s.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Small;
            Assert.Equal<uint>(112, s.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Contains<string>("Water", s.Ingredients);
            Assert.Contains<string>("Natural Flavors", s.Ingredients);
            Assert.Contains<string>("Cane Sugar", s.Ingredients);
            Assert.Equal<int>(3,s.Ingredients.Count);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, s.Size);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasaurus s = new Sodasaurus();          
            Assert.True(s.Ice);
        }

        [Fact]
        public void ShouldHoldIce()
        {
            Sodasaurus s = new Sodasaurus();
            s.HoldIce();
            Assert.False(s.Ice);
        }
        /// <summary>
        /// Checks the description of the entree
        /// </summary>
        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal("Small " + s.Flavor.ToString()+" Sodasaurus", s.Description);
        }
    }
}

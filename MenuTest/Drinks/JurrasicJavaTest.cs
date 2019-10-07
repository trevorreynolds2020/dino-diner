using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Small;
            Assert.Equal<double>(.59, j.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Small;
            Assert.Equal<uint>(2, j.Calories);
        }

        [Fact]
        public void ShouldAddIce()
        {
            JurrasicJava j = new JurrasicJava();
            j.AddIce();
            Assert.True(j.Ice);
        }

        [Fact]
        public void ShouldLeaveSpaceForCream()
        {
            JurrasicJava j = new JurrasicJava();
            j.LeaveRoomForCream();
            Assert.True(j.RoomForCream);
        }
        [Fact]
        public void CaloriesForSmall()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Small;
            Assert.Equal<double>(.59, j.Price);
        }
        [Fact]
        public void PriceForSmall()
        {
            JurrasicJava tea = new JurrasicJava();
            tea.Size = Size.Small;
            Assert.Equal<uint>(2, tea.Calories);
        }
        [Fact]
        public void CaloriesForMedium()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Medium;
            Assert.Equal<double>(.99, j.Price);
        }
        [Fact]
        public void PriceForMedium()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Medium;
            Assert.Equal<uint>(4, j.Calories);
        }
        [Fact]
        public void CaloriesForLarge()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Large;
            Assert.Equal<double>(1.49, j.Price);
        }
        [Fact]
        public void PriceForLarge()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Large;
            Assert.Equal<uint>(8, j.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurrasicJava j = new JurrasicJava();
            Assert.Contains<string>("Water", j.Ingredients);
            Assert.Contains<string>("Coffee", j.Ingredients);
            Assert.Equal<int>(2, j.Ingredients.Count);
        }
    }
}

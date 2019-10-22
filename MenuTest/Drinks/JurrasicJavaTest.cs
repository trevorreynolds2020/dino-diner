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
            JurassicJava j = new JurassicJava();
            j.Size = Size.Small;
            Assert.Equal<double>(.59, j.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Small;
            Assert.Equal<uint>(2, j.Calories);
        }

        [Fact]
        public void ShouldAddIce()
        {
            JurassicJava j = new JurassicJava();
            j.AddIce();
            Assert.True(j.Ice);
        }

        [Fact]
        public void ShouldLeaveSpaceForCream()
        {
            JurassicJava j = new JurassicJava();
            j.LeaveRoomForCream();
            Assert.True(j.RoomForCream);
        }
        [Fact]
        public void CaloriesForSmall()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Small;
            Assert.Equal<double>(.59, j.Price);
        }
        [Fact]
        public void PriceForSmall()
        {
            JurassicJava tea = new JurassicJava();
            tea.Size = Size.Small;
            Assert.Equal<uint>(2, tea.Calories);
        }
        [Fact]
        public void CaloriesForMedium()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            Assert.Equal<double>(.99, j.Price);
        }
        [Fact]
        public void PriceForMedium()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            Assert.Equal<uint>(4, j.Calories);
        }
        [Fact]
        public void CaloriesForLarge()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Large;
            Assert.Equal<double>(1.49, j.Price);
        }
        [Fact]
        public void PriceForLarge()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Large;
            Assert.Equal<uint>(8, j.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurassicJava j = new JurassicJava();
            Assert.Contains<string>("Water", j.Ingredients);
            Assert.Contains<string>("Coffee", j.Ingredients);
            Assert.Equal<int>(2, j.Ingredients.Count);
        }
        /// <summary>
        /// Checks the description of the drink
        /// </summary>
        [Fact]
        public void DescriptionShouldBeCorrectForDecaf()
        {
            JurassicJava j = new JurassicJava();
            j.Decaf = true;
            Assert.Equal($"{j.Size} Decaf Jurassic Java", j.Description);
        }
        /// <summary>
        /// Checks the description of the drink
        /// </summary>
        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            JurassicJava j = new JurassicJava();
            Assert.Equal($"{j.Size} Jurassic Java", j.Description);
        }
        /// <summary>
        /// Checks make there are no special instructions for a new instance of entree
        /// </summary>
        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            JurassicJava j = new JurassicJava();
            Assert.Empty(j.Special);
        }
        /// <summary>
        /// Checks whether or not the leave room for cream property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void RoomForCreamShouldAddToSpecial()
        {
            JurassicJava j = new JurassicJava();
            j.LeaveRoomForCream();
            if (j.RoomForCream == false)
            {
                Assert.Collection<string>(j.Special,
                    item =>
                    {
                        Assert.Equal("Hold Cream", item);
                    });
            }
        }
        /// <summary>
        /// Checks whether or not the ice is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void AddIceShouldAddToSpecial()
        {
            JurassicJava j = new JurassicJava();
            j.AddIce();
            Assert.Collection<string>(j.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            });
        }
        /// <summary>
        /// Checks whether or not the leave room for cream property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void RoomForCreamAndAddIceShouldAddToSpecial()
        {
            JurassicJava j = new JurassicJava();
            j.AddIce();
            j.LeaveRoomForCream();

            if (j.RoomForCream == false && j.Ice == false)
            {
                Assert.Collection<string>(j.Special,
                    item =>
                    {
                        Assert.Equal($"{j.Size}", item);
                    },
                    item =>
                    {
                        Assert.Equal("Hold Cream", item);
                    },
                    item =>
                    {
                        Assert.Equal("Hold Ice", item);
                    });
            }
        }
        /// <summary>
        /// Should update special instructions list
        /// </summary>
        [Fact]
        public void RoomForCreamShouldNotifySpecialChange()
        {
            JurassicJava j = new JurassicJava();
            Assert.PropertyChanged(j, "Special", () =>
            {
                j.LeaveRoomForCream();
            });
        }
        /// <summary>
        /// Should update special instructions list
        /// </summary>
        [Fact]
        public void AddIceShouldNotifySpecialChange()
        {
            JurassicJava j = new JurassicJava();
            Assert.PropertyChanged(j, "Special", () =>
            {
                j.AddIce();
            });
        }
        /// <summary>
        /// Checks name for a given size
        /// </summary>
        [Fact]
        public void DescriptionShouldBeCorrectForSmall()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Small;
            Assert.Equal("Small Jurassic Java", j.Description);
        }
        /// <summary>
        /// Checks name for a given size
        /// </summary>
        [Fact]
        public void DescriptionShouldBeCorrectForMedium()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            Assert.Equal("Medium Jurassic Java", j.Description);
        }
        /// <summary>
        /// Checks name for a given size
        /// </summary>
        [Fact]
        public void DescriptionShouldBeCorrectForLarge()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Large;
            Assert.Equal("Large Jurassic Java", j.Description);
        }
        /// <summary>
        /// Checks if change of price effects the price property for the drink
        /// </summary>
        [Fact]
        public void ChangingSizeToSmallShouldNotifyPriceChange()
        {
            JurassicJava j = new JurassicJava();
            Assert.PropertyChanged(j, "Price", () =>
            {
                j.Size = Size.Small;
            });
        }
        /// <summary>
        /// Checks if change of price effects the price property for the drink
        /// </summary>
        [Fact]
        public void ChangingSizeToMediumShouldNotifyPriceChange()
        {
            JurassicJava j = new JurassicJava();
            Assert.PropertyChanged(j, "Price", () =>
            {
                j.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeToLargeShouldNotifyPriceChange()
        {
            JurassicJava j = new JurassicJava();
            Assert.PropertyChanged(j, "Price", () =>
            {
                j.Size = Size.Large;
            });
        }
    }
}

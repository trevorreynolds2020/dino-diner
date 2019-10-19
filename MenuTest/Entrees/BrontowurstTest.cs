using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }
        /// <summary>
        /// Checks the description of the entree
        /// </summary>
        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal("Brontoworst", pbj.Description);
        }
        /// <summary>
        /// Checks make there are no special instructions for a new instance of entree
        /// </summary>
        [Fact]
        public void SpeicalShouldBeEmptyByDefault()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Empty(pbj.Special);
        }
        /// <summary>
        /// Checks whether or not the bun property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldBunShouldAddToSpecial()
        {
            Brontowurst b = new Brontowurst();
            b.HoldBun();
            Assert.Collection<string>(b.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            });
        }
        /// <summary>
        /// Checks whether or not the pepper property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldPeppersShouldAddToSpecial()
        {
            Brontowurst b = new Brontowurst();
            b.HoldPeppers();
            Assert.Collection<string>(b.Special, item =>
            {
                Assert.Equal("Hold Peppers", item);
            });
        }
        /// <summary>
        /// Checks whether or not the onion property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldOnionShouldAddToSpecial()
        {
            Brontowurst b = new Brontowurst();
            b.HoldOnion();
            Assert.Collection<string>(b.Special, item =>
            {
                Assert.Equal("Hold Onion", item);
            });
        }
        /// <summary>
        /// Checks whether or not all properties are changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldAllItemsShouldAddToSpecial()
        {
            Brontowurst b = new Brontowurst();
            b.HoldBun();
            b.HoldPeppers();
            b.HoldOnion();
            Assert.Collection<string>(b.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            },
            item =>
            {
                Assert.Equal("Hold Peppers", item);
            },
            item =>
            {
                Assert.Equal("Hold Onion", item);
            }
            );
        }

        /// <summary>
        /// Should update special instructions list
        /// </summary>
        [Fact]
        public void HoldingBunShouldNotifySpecialChange()
        {
            Brontowurst b = new Brontowurst();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldBun();
            });
        }
        /// <summary>
        /// Should update special instructions list
        /// </summary>
        [Fact]
        public void HoldingPeppersShouldNotifySpecialChange()
        {
            Brontowurst b = new Brontowurst();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldPeppers();
            });
        }
        /// <summary>
        /// Should update special instructions list
        /// </summary>
        [Fact]
        public void HoldingOnionShouldNotifySpecialChange()
        {
            Brontowurst b = new Brontowurst();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldOnion();
            });
        }
    }

}

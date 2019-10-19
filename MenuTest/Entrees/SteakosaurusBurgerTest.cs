using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }
        /// <summary>
        /// Checks the description of the entree
        /// </summary>
        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", s.Description);
        }
        /// <summary>
        /// Checks make there are no special instructions for a new instance of entree
        /// </summary>
        [Fact]
        public void SpeicalShouldBeEmptyByDefault()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.Empty(s.Special);
        }

        /// <summary>
        /// Checks whether or not the bun property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldBunShouldAddToSpecial()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldBun();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            });
        }
        /// <summary>
        /// Checks whether or not the pickle property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldPickleShouldAddToSpecial()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldPickle();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Pickle", item);
            });
        }
        /// <summary>
        /// Checks whether or not the bun property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldKetchupShouldAddToSpecial()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldKetchup();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Ketchup", item);
            });
        }
        /// <summary>
        /// Checks whether or not the mustard property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldMustardShouldAddToSpecial()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldMustard();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Mustard", item);
            });
        }

        /// <summary>
        /// Checks whether or not the mustard property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldAllItemsShouldAddToSpecial()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldBun();
            s.HoldPickle();
            s.HoldKetchup();
            s.HoldMustard();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            },
            item =>
            {
                Assert.Equal("Hold Pickle", item);
            },
            item =>
            {
                Assert.Equal("Hold Ketchup", item);
            },
            item =>
            {
                Assert.Equal("Hold Mustard", item);
            });
        }
        /// <summary>
        /// Should update special instructions list
        /// </summary>
        [Fact]
        public void HoldingBunShouldNotifySpecialChange()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.PropertyChanged(s, "Special", () =>
            {
                s.HoldBun();
            });
        }
        /// <summary>
        /// Should update special instructions list
        /// </summary>
        [Fact]
        public void HoldingPickleShouldNotifySpecialChange()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.PropertyChanged(s, "Special", () =>
            {
                s.HoldPickle();
            });
        }
        /// <summary>
        /// Should update special instructions list
        /// </summary>
        [Fact]
        public void HoldingKetchupShouldNotifySpecialChange()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.PropertyChanged(s, "Special", () =>
            {
                s.HoldKetchup();
            });
        }
        /// <summary>
        /// Should update special instructions list
        /// </summary>
        [Fact]
        public void HoldingMustardShouldNotifySpecialChange()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.PropertyChanged(s, "Special", () =>
            {
                s.HoldMustard();
            });
        }
    }

}

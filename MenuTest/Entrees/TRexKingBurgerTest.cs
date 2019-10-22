using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }
        /// <summary>
        /// Checks whether or not the bun property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldBunShouldAddToSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldBun();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            });
        }
        /// <summary>
        /// Checks whether or not the Lettuce property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldLettuceShouldAddToSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldLettuce();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Lettuce", item);
            });
        }
        /// <summary>
        /// Checks whether or not the tomato property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldTomatoShouldAddToSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldTomato();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Tomato", item);
            });
        }
        /// <summary>
        /// Checks whether or not the Onion property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldOnionShouldAddToSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldOnion();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Onion", item);
            });
        }
        /// <summary>
        /// Checks whether or not the pickle property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldPickleShouldAddToSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldPickle();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Pickle", item);
            });
        }
        /// <summary>
        /// Checks whether or not the ketchup property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldKetchupShouldAddToSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldKetchup();
            Assert.Collection<string>(t.Special, item =>
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
            TRexKingBurger t = new TRexKingBurger();
            t.HoldMustard();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Mustard", item);
            });
        }
        /// <summary>
        /// Checks whether or not the mayo property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldNayoShouldAddToSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldMayo();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Mayo", item);
            });
        }
        /// <summary>
        /// Checks whether or not all properties are changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldAllItemsShouldAddToSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldBun();
            t.HoldLettuce();
            t.HoldTomato();
            t.HoldOnion();
            t.HoldPickle();
            t.HoldKetchup();
            t.HoldMustard();
            t.HoldMayo();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Bun", item);

            },
            item =>
            {
                Assert.Equal("Hold Lettuce", item);
            },
            item =>
            {
                Assert.Equal("Hold Tomato", item);
            },
            item =>
            {
                Assert.Equal("Hold Onion", item);
            },
            item =>
            {
                Assert.Equal("Hold Pickle", item);
            },
            item =>
            {
                Assert.Equal("Hold Mustard", item);
            },
            item =>
            {
                Assert.Equal("Hold Ketchup", item);
            },
            item =>
            {
                Assert.Equal("Hold Mayo", item);
            }
            );
        }
        /// <summary>
        /// Should update special instructions list
        /// </summary>
        [Fact]
        public void HoldingBunShouldNotifySpecialChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.HoldBun();
            });
        }
        /// <summary>
        /// Should update special instructions list
        /// </summary>
        [Fact]
        public void HoldingLettuceShouldNotifySpecialChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.HoldLettuce();
            });
        }
        /// <summary>
        /// Should update special instructions list
        /// </summary>
        [Fact]
        public void HoldingTomatoShouldNotifySpecialChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.HoldTomato();
            });
        }
        /// <summary>
        /// Should update special instructions list
        /// </summary>
        [Fact]
        public void HoldingOnionShouldNotifySpecialChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.HoldOnion();
            });
        }
        /// <summary>
        /// Should update special instructions list
        /// </summary>
        [Fact]
        public void HoldingPickleShouldNotifySpecialChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.HoldPickle();
            });
        }
        /// <summary>
        /// Should update special instructions list
        /// </summary>
        [Fact]
        public void HoldingKetchupShouldNotifySpecialChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.HoldKetchup();
            });
        }
        /// <summary>
        /// Should update special instructions list
        /// </summary>
        [Fact]
        public void HoldingMustardShouldNotifySpecialChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.HoldMustard();
            });
        }
        /// <summary>
        /// Should update special instructions list
        /// </summary>
        [Fact]
        public void HoldingMayoShouldNotifySpecialChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.HoldMayo();
            });
        }


    }

}

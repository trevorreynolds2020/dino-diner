using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Ceasar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain<string>("Ceasar Dressing", vw.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain<string>("Romaine Lettuce", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", vw.Ingredients);
        }
        /// <summary>
        /// Checks the description of the entree
        /// </summary>
        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            VelociWrap v = new VelociWrap();
            Assert.Equal("Veloci-Wrap", v.Description);
        }
        /// <summary>
        /// Checks make there are no special instructions for a new instance of entree
        /// </summary>
        [Fact]
        public void SpeicalShouldBeEmptyByDefault()
        {
            VelociWrap v = new VelociWrap();
            Assert.Empty(v.Special);
        }
        /// <summary>
        /// Checks whether or not the dressing property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldDressingShouldAddToSpecial()
        {
            VelociWrap v = new VelociWrap();
            v.HoldDressing();
            Assert.Collection<string>(v.Special, item =>
            {
                Assert.Equal("Hold Ceasar Dressing", item);
            });
        }
        /// <summary>
        /// Checks whether or not the lettuce property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldLettuceShouldAddToSpecial()
        {
            VelociWrap v = new VelociWrap();
            v.HoldLettuce();
            Assert.Collection<string>(v.Special, item =>
            {
                Assert.Equal("Hold Romaine Lettuce", item);
            });
        }
        /// <summary>
        /// Checks whether or not the cheese property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldCheeseShouldAddToSpecial()
        {
            VelociWrap v = new VelociWrap();
            v.HoldCheese();
            Assert.Collection<string>(v.Special, item =>
            {
                Assert.Equal("Hold Parmesan Cheese", item);
            });
        }
        /// <summary>
        /// Checks whether or not all properties are changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldingAllItemsShouldAddToSpecial()
        {
            VelociWrap v = new VelociWrap();
            v.HoldCheese();
            v.HoldLettuce();
            v.HoldDressing();
            Assert.Collection<string>(v.Special,
                item =>
                {
                    Assert.Equal("Hold Parmesan Cheese", item);
                },
                item =>
                {
                    Assert.Equal("Hold Romaine Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ceasar Dressing", item);
                });
        }

    }
}


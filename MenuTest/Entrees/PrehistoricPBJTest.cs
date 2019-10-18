using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class PrehistoricPBJUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal(6.52, pbj.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal<uint>(483, pbj.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            List<string> ingredients = pbj.Ingredients;
            Assert.Contains<string>("Bread", ingredients);
            Assert.Contains<string>("Peanut Butter", ingredients);
            Assert.Contains<string>("Jelly", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

        [Fact]
        public void HoldPeanutButterShouldRemovePeanutButter()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            Assert.DoesNotContain<string>("Peanut Butter", pbj.Ingredients);
        }

        [Fact]
        public void HoldJellyShouldRemoveJelly()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            Assert.DoesNotContain<string>("Jelly", pbj.Ingredients);
        }
        /// <summary>
        /// Checks the description of the entree
        /// </summary>
        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal("Prehistoric PB&J", pbj.Description);
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
        /// Checks whether or not the peanut butter property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldPeanutButterShouldAddToSpecial()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            Assert.Collection<string>(pbj.Special, item =>
            {
                Assert.Equal("Hold Peanut Butter", item);
            });
        }
        /// <summary>
        /// Checks whether or not the jelly property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldJellyShouldAddToSpecial()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            Assert.Collection<string>(pbj.Special, item =>
            {
                Assert.Equal("Hold Jelly", item);
            });
        }
        /// <summary>
        /// Checks whether or not the jelly and peanut butter property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void HoldPeanutButterAndJellyShouldAddToSpecial()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            pbj.HoldJelly();
            Assert.Collection<string>(pbj.Special, item =>
            {
                Assert.Equal("Hold Peanut Butter", item);
  
            },
            item =>
            {
                Assert.Equal("Hold Jelly", item);
            }
            );
        }
        /// <summary>
        /// Should update special instructions list
        /// </summary>
        [Fact]
        public void HoldingPeanutButterShouldNotifySpecialChange()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Special", () =>
            {
                pbj.HoldPeanutButter();
            });
        }
        /// <summary>
        /// Should update special instructions list
        /// </summary>
        [Fact]
        public void HoldingJellyShouldNotifySpecialChange()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Special", () =>
            {
                pbj.HoldJelly();
            });
        }
    }

}

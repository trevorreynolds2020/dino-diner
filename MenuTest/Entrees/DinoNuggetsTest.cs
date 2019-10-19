using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class DinoNuggetsUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Equal(4.25, dn.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Equal<uint>(59*6, dn.Calories);
        }


        [Fact]
        public void ShouldListDefaultIngredients()
        {
            DinoNuggets dn = new DinoNuggets();
            List<string> ingredients = dn.Ingredients;
            // Should be six nuggets
            int nuggetCount = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal(6, nuggetCount);
            Assert.Equal<int>(6, ingredients.Count);
        }

        [Fact]
        public void AddingNuggetsShouldAddIngredients()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            // Should be seven nuggets
            int nuggetCount = 0;
            foreach (string ingredient in dn.Ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal<int>(7, nuggetCount);
            Assert.Equal<int>(7, dn.Ingredients.Count);

            dn.AddNugget();
            // Should be 8 nuggets
            nuggetCount = 0;
            foreach (string ingredient in dn.Ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal<int>(8, nuggetCount);
            Assert.Equal<int>(8, dn.Ingredients.Count);

        }

        [Fact]
        public void AddingNuggetsShouldIncreasePrice()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            Assert.Equal(dn.Price, 4.50, 2);
            dn.AddNugget();
            Assert.Equal(dn.Price, 4.75, 2);
            dn.AddNugget();
            Assert.Equal(dn.Price, 5.0, 2);
        }

        [Fact]
        public void AddingNuggetsShouldIncreaseCalories()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            Assert.Equal<uint>(dn.Calories, 59*7);
            dn.AddNugget();
            Assert.Equal<uint>(dn.Calories, 59*8);
            dn.AddNugget();
            Assert.Equal<uint>(dn.Calories, 59*9);
        }
        /// <summary>
        /// Checks the description of the entree
        /// </summary>
        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            DinoNuggets d = new DinoNuggets();
            Assert.Equal("Dino-Nuggets", d.Description);
        }
        /// <summary>
        /// Checks make there are no special instructions for a new instance of entree
        /// </summary>
        [Fact]
        public void SpeicalShouldBeEmptyByDefault()
        {
            DinoNuggets d = new DinoNuggets();
            Assert.Empty(d.Special);
        }
        /// <summary>
        /// Checks whether or not the nugget count property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void AddNuggetShouldAddToSpecial()
        {
            DinoNuggets d = new DinoNuggets();
            d.AddNugget();
            Assert.Collection<string>(d.Special, item =>
            {
                Assert.Equal("1 Extra Nuggets", item);
            });
        }
        /// <summary>
        /// Checks whether or not the nugget count property is changed, and the special list is updated
        /// </summary>
        [Fact]
        public void AddNuggetMultipleNuggetsShouldAddToSpecial()
        {
            DinoNuggets d = new DinoNuggets();
            d.AddNugget();
            d.AddNugget();
            d.AddNugget();
            d.AddNugget();
            Assert.Collection<string>(d.Special, item =>
            {
                Assert.Equal("4 Extra Nuggets", item);
            });
        }
        /// <summary>
        /// Should update special instructions list
        /// </summary>
        [Fact]
        public void AddingNuggetShouldNotifySpecialChange()
        {
            DinoNuggets d = new DinoNuggets();
            Assert.PropertyChanged(d, "Special", () =>
            {
                d.AddNugget();
            });
        }

    }
}
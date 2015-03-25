using System.Collections.Generic;
using NUnit.Framework;
using RulesEngine.IntegrationTests.TestObjects;

namespace RulesEngine.IntegrationTests
{
    [TestFixture]
    public class RulesEngineTests
    {
        [Test]
        public void ShouldGetOnePoundDiscountAndNoFreeShipping()
        {
            // ARRANGE
            var productA = new Product { Price = 1.00m, Name = "Test Product 1" };
            var productB = new Product { Price = 2.00m, Name = "Test Product 2" };

            var cart = new ShoppingCart
            {
                Products = new List<Product> {productA, productB, productA, productA}
            };

            // ACT
            cart.ExecuteRules();

            // ASSERT
            const decimal expectedTotal = 4.00m;
            Assert.That(cart.FreeShippng, Is.False);
            Assert.That(cart.TotalValue, Is.EqualTo(expectedTotal));
        }

        [Test]
        public void ShouldGetFreeShipping()
        {
            // ARRANGE
            var productA = new Product { Price = 1.00m, Name = "Test Product 1" };
            var productB = new Product { Price = 2.00m, Name = "Test Product 2" };
            var productC = new Product { Price = 3.00m, Name = "Test Product 3" };

            var cart = new ShoppingCart
            {
                Products = new List<Product> { productA, productB, productA, productB, productA, productC }
            };

            // ACT
            cart.ExecuteRules();

            // ASSERT
            Assert.That(cart.FreeShippng, Is.True);
        }
    }
}

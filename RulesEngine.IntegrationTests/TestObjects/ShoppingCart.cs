using System.Collections.Generic;
using System.Linq;
using RulesEngine.IntegrationTests.TestRules;
using RulesEngine.Interfaces;

namespace RulesEngine.IntegrationTests.TestObjects
{
    public class ShoppingCart : IRuleable
    {
        public ShoppingCart()
        {
            Products = new List<Product>();
        }

        public bool FreeShippng { get; set; }
        public IList<Product> Products { get; set; }

        public decimal TotalValue
        {
            get { return Products.Sum(p => p.Price); }
        }

        public void ExecuteRules()
        {
            this.ApplyRule(new BuyThreeGetOnePoundDiscountRule("Test Product 1"));
            this.ApplyRule(new FreeShippingRule.FreeShipping());
        }
    }
}

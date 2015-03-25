using System.Linq;
using RulesEngine.Conditions;
using RulesEngine.IntegrationTests.TestObjects;

namespace RulesEngine.IntegrationTests.TestRules
{
    public class BuyThreeGetOnePoundDiscountRule : BaseRule<ShoppingCart>
    {
        private readonly string _productName;

        public BuyThreeGetOnePoundDiscountRule(string productName)
        {
            _productName = productName;
        }

        public override void Initialize(ShoppingCart cart)
        {
            Conditions.Add(new AreEqualCondition(3, cart.Products.Count(p => p.Name == _productName)));
        }

        public override ShoppingCart Apply(ShoppingCart cart)
        {
            cart.Products.Add(new Product {Name = "Discount", Price = -1.00m});
            return cart;
        }
    }
}

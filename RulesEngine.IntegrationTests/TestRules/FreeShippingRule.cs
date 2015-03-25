using RulesEngine.IntegrationTests.TestObjects;
using RulesEngine.Conditions;

namespace RulesEngine.IntegrationTests.TestRules
{
    public class FreeShippingRule
    {
        public class FreeShipping : BaseRule<ShoppingCart>
        {
            public override void Initialize(ShoppingCart obj)
            {
                Conditions.Add(new GreaterThanCondition(8.00m, obj.TotalValue));
            }

            public override ShoppingCart Apply(ShoppingCart obj)
            {
                obj.FreeShippng = true;
                return obj;
            }
        }
    }
}

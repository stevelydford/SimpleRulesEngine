using RulesEngine.Interfaces;

namespace RulesEngine.Conditions
{
    public class IsNaNCondition : ICondition
    {
        private readonly double _value;

        public IsNaNCondition(double value)
        {
            _value = value;
        }

        public bool IsSatisfied()
        {
            return double.IsNaN(_value);
        }
    }
}

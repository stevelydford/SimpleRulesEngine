using RulesEngine.Interfaces;

namespace RulesEngine.Conditions
{
    public class GreaterThanCondition : ICondition
    {
        private readonly decimal _actual;
        private readonly decimal _threshold;

        public GreaterThanCondition(decimal threshold, decimal actual)
        {
            _threshold = threshold;
            _actual = actual;
        }

        public bool IsSatisfied()
        {
            return _actual > _threshold;
        }
    }
}

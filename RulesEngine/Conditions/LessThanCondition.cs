using RulesEngine.Interfaces;

namespace RulesEngine.Conditions
{
    public class LessThanCondition : ICondition
    {
        private readonly decimal _actual;
        private readonly decimal _threshold;

        public LessThanCondition(decimal threshold, decimal actual)
        {
            _threshold = threshold;
            _actual = actual;
        }

        public bool IsSatisfied()
        {
            return _actual < _threshold;
        }
    }
}

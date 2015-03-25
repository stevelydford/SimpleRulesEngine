using RulesEngine.Interfaces;

namespace RulesEngine.Conditions
{
    public class AreNotEqualCondition : ICondition
    {
        private readonly int _actual;
        private readonly int _threshold;

        public AreNotEqualCondition(int threshold, int actual)
        {
            _threshold = threshold;
            _actual = actual;
        }

        public bool IsSatisfied()
        {
            return _actual != _threshold;
        }
    }
}

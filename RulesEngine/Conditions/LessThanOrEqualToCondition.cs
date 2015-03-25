namespace RulesEngine.Conditions
{
    public class LessThanOrEqualToCondition
    {
        private readonly decimal _actual;
        private readonly decimal _threshold;

        public LessThanOrEqualToCondition(decimal threshold, decimal actual)
        {
            _threshold = threshold;
            _actual = actual;
        }

        public bool IsSatisfied()
        {
            return _actual <= _threshold;
        }
    }
}

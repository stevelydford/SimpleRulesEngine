using RulesEngine.Interfaces;

namespace RulesEngine.Conditions
{
    public class IsTrueCondition : ICondition
    {
        private readonly bool _condition;

        public IsTrueCondition(bool condition)
        {
            _condition = condition;
        }

        public bool IsSatisfied()
        {
            return _condition == true;
        }
    }
}

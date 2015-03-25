using RulesEngine.Interfaces;

namespace RulesEngine.Conditions
{
    public class IsFalseCondition : ICondition
    {
        private readonly bool _condition;

        public IsFalseCondition(bool condition)
        {
            _condition = condition;
        }

        public bool IsSatisfied()
        {
            return _condition == false;
        }
    }
}

using RulesEngine.Interfaces;

namespace RulesEngine.Conditions
{
    public class IsNullCondition : ICondition
    {
        private readonly object _obj;

        public IsNullCondition(object obj)
        {
            _obj = obj;
        }

        public bool IsSatisfied()
        {
            return _obj == null;
        }
    }
}

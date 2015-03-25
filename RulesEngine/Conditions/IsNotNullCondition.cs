using RulesEngine.Interfaces;

namespace RulesEngine.Conditions
{
    public class IsNotNullCondition : ICondition
    {
        private readonly object _obj;

        public IsNotNullCondition(object obj)
        {
            _obj = obj;
        }

        public bool IsSatisfied()
        {
            return _obj != null;
        }
    }
}

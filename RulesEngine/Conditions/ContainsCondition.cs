using System.Collections;
using RulesEngine.Interfaces;

namespace RulesEngine.Conditions
{
    public class ContainsCondition : ICondition
    {
        private readonly IList _collection;
        private readonly object _obj;

        public ContainsCondition(IList collection, object obj)
        {
            _collection = collection;
            _obj = obj;
        }

        public bool IsSatisfied()
        {
            return _collection.Contains(_obj);
        }
    }
}

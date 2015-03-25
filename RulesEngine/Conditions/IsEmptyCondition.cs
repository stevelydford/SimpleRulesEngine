using System.Collections;
using RulesEngine.Interfaces;

namespace RulesEngine.Conditions
{
    public class IsEmptyCondition : ICondition
    {
        private readonly string _string;
        private readonly ICollection _collection;
        private readonly bool _isStringComparison;

        public IsEmptyCondition(string stringValue)
        {
            _isStringComparison = true;
            _string = stringValue;
        }

        public IsEmptyCondition(ICollection collection)
        {
            _isStringComparison = false;
            _collection = collection;
        }

        public bool IsSatisfied()
        {
            if (_isStringComparison)
                return _string == string.Empty;
            else
                return _collection.Count == 0;
        }
    }
}

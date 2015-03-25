using System.Collections.Generic;
using RulesEngine.Interfaces;

namespace RulesEngine
{
    public static class RulesEngine
    {
        public static T ApplyRules<T>(this T obj, List<IRule<T>> rules) where T : IRuleable
        {
            foreach (var rule in rules)
            {
                obj.ApplyRule(rule);
            }
            return obj;
        }

        public static T ApplyRule<T>(this T obj, IRule<T> rule) where T : IRuleable
        {
            rule.ClearConditions();
            rule.Initialize(obj);
            if (rule.IsValid())
            {
                rule.Apply(obj);
            }
            return obj;
        }
    }
}

using System;
using NUnit.Framework;
using RulesEngine.Conditions;

namespace RulesEngine.Tests.Conditions
{
    [TestFixture]
    public class ContainsConditionTests
    {
        [Test]
        public void ShouldReturnTrueWhenCollectionContainsObject()
        {
            var testArray = new string[] { "Apple", "Banana", "Cabbage" };

            var condition = new ContainsCondition(testArray, "Banana");
            var result = condition.IsSatisfied();
            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenCollectionDoesNotContainObject()
        {
            var testArray = new string[] { "Apple", "Banana", "Cabbage" };

            var condition = new ContainsCondition(testArray, "Damson");
            var result = condition.IsSatisfied();
            Assert.That(result, Is.False);
        }
    }
}

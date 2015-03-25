using System.Collections.Generic;
using NUnit.Framework;
using RulesEngine.Conditions;

namespace RulesEngine.Tests.Conditions
{
    [TestFixture]
    public class IsEmptyConditionTests
    {
        [Test]
        public void ShouldReturnTrueWhenPassedAnEmptyString()
        {
            var condition = new IsEmptyCondition("");
            var result = condition.IsSatisfied();
            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenPassedANonEmptyString()
        {
            var condition = new IsEmptyCondition("test");
            var result = condition.IsSatisfied();
            Assert.That(result, Is.False);
        }

        [Test]

        public void ShouldReturnTrueWhenPassedAnEmptyCollection()
        {
            var testCollection = new List<string>();

            var condition = new IsEmptyCondition(testCollection);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.True);
        }

        [Test]

        public void ShouldReturnFalseWhenPassedANonEmptyCollection()
        {
            var testCollection = new List<string> { "test" };

            var condition = new IsEmptyCondition("test");
            var result = condition.IsSatisfied();
            Assert.That(result, Is.False);
        }
    }
}

using System.Collections.Generic;
using NUnit.Framework;
using RulesEngine.Conditions;

namespace RulesEngine.Tests.Conditions
{
    [TestFixture]
    public class IsNotEmptyConditionTests
    {
        [Test]
        public void ShouldReturnTrueWhenPassedANonEmptyString()
        {
            var condition = new IsNotEmptyCondition("test");
            var result = condition.IsSatisfied();
            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenPassedAnEmptyString()
        {
            var condition = new IsNotEmptyCondition("");
            var result = condition.IsSatisfied();
            Assert.That(result, Is.False);
        }

        [Test]

        public void ShouldReturnTrueWhenPassedANonEmptyCollection()
        {
            var testCollection = new List<string> { "test" };

            var condition = new IsNotEmptyCondition("test");
            var result = condition.IsSatisfied();
            Assert.That(result, Is.True);
        }

         [Test]
        public void ShouldReturnFalseWhenPassedAnEmptyCollection()
        {
            var testCollection = new List<string>();

            var condition = new IsNotEmptyCondition(testCollection);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.False);
        }
    }
}

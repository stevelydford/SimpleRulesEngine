using System;
using NUnit.Framework;
using RulesEngine.Conditions;

namespace RulesEngine.Tests.Conditions
{
    [TestFixture]
    public class IsNaNConditionTests
    {
        [Test]
        public void ShouldReturnTrueWhenPassedANaNValue()
        {
            var testValue = Math.Sqrt(-1);

            var condition = new IsNaNCondition(testValue);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenPassedANonNaNValue()
        {
            var testValue = Math.Sqrt(1);

            var condition = new IsNaNCondition(testValue);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.False);
        }
    }
}

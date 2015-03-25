using System.Security.Cryptography;
using NUnit.Framework;
using RulesEngine.Conditions;

namespace RulesEngine.Tests.Conditions
{
    [TestFixture]
    public class IsFalseConditionTests
    {
        [Test]
        public void ShouldReturnTrueWhenPassedAFalseValue()
        {
            var condition = new IsFalseCondition(1 == 2);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenPassedATrueValue()
        {
            var condition = new IsFalseCondition(1 == 1);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.False);
        }
    }
}

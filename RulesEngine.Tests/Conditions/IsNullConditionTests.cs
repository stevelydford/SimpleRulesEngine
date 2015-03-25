using NUnit.Framework;
using RulesEngine.Conditions;

namespace RulesEngine.Tests.Conditions
{
    [TestFixture]
    public class IsNullConditionTests
    {
        [Test]
        public void ShouldReturnTrueWhenPassedANullValue()
        {
            var condition = new IsNullCondition(null);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenPassedANullValue()
        {
            var condition = new IsNullCondition(true);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.False);
        }
    }
}

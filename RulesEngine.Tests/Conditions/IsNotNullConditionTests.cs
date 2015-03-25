using NUnit.Framework;
using RulesEngine.Conditions;

namespace RulesEngine.Tests.Conditions
{
    [TestFixture]
    public class IsNotNullConditionTests
    {
        [Test]
        public void ShouldReturnTrueWhenPassedANonNullValue()
        {
            var condition = new IsNotNullCondition(true);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenPassedANullValue()
        {
            var condition = new IsNotNullCondition(null);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.False);
        }
    }
}

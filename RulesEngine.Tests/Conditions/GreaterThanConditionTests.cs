using NUnit.Framework;
using RulesEngine.Conditions;

namespace RulesEngine.Tests.Conditions
{
    [TestFixture]
    public class GreaterThanConditionTests
    {
        [Test]
        public void ShouldReturnTrueWhenActualIsGreaterThanThreshold()
        {
            var condition = new GreaterThanCondition(1, 2);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenActualIsLessThanThreshold()
        {
            var condition = new GreaterThanCondition(2, 1);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.False);
        }

        [Test]
        public void ShouldReturnFalseWhenActualIsEqualToThreshold()
        {
            var condition = new GreaterThanCondition(1, 1);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.False);
        }
    }
}

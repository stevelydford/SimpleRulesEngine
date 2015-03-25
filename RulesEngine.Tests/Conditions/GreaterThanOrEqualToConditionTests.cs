using NUnit.Framework;
using RulesEngine.Conditions;

namespace RulesEngine.Tests.Conditions
{
    [TestFixture]
    public class GreaterThanOrEqualToConditionTests
    {
        [Test]
        public void ShouldReturnTrueWhenActualIsGreaterThanThreshold()
        {
            var condition = new GreaterThanOrEqualToCondition(1, 2);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenActualIsLessThanThreshold()
        {
            var condition = new GreaterThanOrEqualToCondition(2, 1);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.False);
        }

        [Test]
        public void ShouldReturnTrueWhenActualIsEqualToThreshold()
        {
            var condition = new GreaterThanOrEqualToCondition(1, 1);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.True);
        }
    }
}

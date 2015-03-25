using NUnit.Framework;
using RulesEngine.Conditions;

namespace RulesEngine.Tests.Conditions
{
    [TestFixture]
    public class LessThanOrEqualToConditionTests
    {
        [Test]
        public void ShouldReturnTrueWhenActualIsLessThanThreshold()
        {
            var condition = new LessThanOrEqualToCondition(2, 1);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenActualIsGreaterThanThreshold()
        {
            var condition = new LessThanOrEqualToCondition(1, 2);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.False);
        }

        [Test]
        public void ShouldReturnTrueWhenActualIsEqualToThreshold()
        {
            var condition = new LessThanOrEqualToCondition(1, 1);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.True);
        }
    }
}

using NUnit.Framework;
using RulesEngine.Conditions;

namespace RulesEngine.Tests.Conditions
{
    [TestFixture]
    public class LessThanConditionTests
    {
        [Test]
        public void ShouldReturnTrueWhenActualIsLessThanThreshold()
        {
            var condition = new LessThanCondition(2, 1);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenActualIsGreaterThanThreshold()
        {
            var condition = new LessThanCondition(1, 2);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.False);
        }

        [Test]
        public void ShouldReturnFalseWhenActualIsEqualToThreshold()
        {
            var condition = new LessThanCondition(1, 1);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.False);
        }
    }
}

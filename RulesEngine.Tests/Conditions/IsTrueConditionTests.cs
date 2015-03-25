using NUnit.Framework;
using RulesEngine.Conditions;

namespace RulesEngine.Tests.Conditions
{
    [TestFixture]
    public class IsTrueConditionTests
    {

        [Test]
        public void ShouldReturnTrueWhenPassedATrueValue()
        {
            var condition = new IsTrueCondition(1 == 1);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenPassedAFalseValue()
        {
            var condition = new IsTrueCondition(1 == 2);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.False);
        }
    }
}

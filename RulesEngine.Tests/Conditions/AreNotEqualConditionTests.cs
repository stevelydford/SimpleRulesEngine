using NUnit.Framework;
using RulesEngine.Conditions;

namespace RulesEngine.Tests.Conditions
{
    [TestFixture]
    public class AreNotEqualConditionTests
    {
        [Test]
        public void ShouldReturnTrueWhenValuesAreNotEqual()
        {
            var condition = new AreNotEqualCondition(1, 2);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenValuesAreEqual()
        {
            var condition = new AreNotEqualCondition(1, 1);
            var result = condition.IsSatisfied();
            Assert.That(result, Is.False);
        }
    }
}

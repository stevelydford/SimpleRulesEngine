using NUnit.Framework;
using RulesEngine.Conditions;

namespace RulesEngine.Tests.Conditions
{
    [TestFixture]
    public class AreEqualConditionTests
    {
        [Test]
        public void ShouldReturnTrueWhenValuesAreEqual()
        {
            var condition = new AreEqualCondition(1, 1);

            var result = condition.IsSatisfied();

            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenValuesAreNotEqual()
        {
            var condition = new AreEqualCondition(1, 2);

            var result = condition.IsSatisfied();

            Assert.That(result, Is.False);
        }
    }
}

using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse6._Spec._BuzzPredicate.New.NotDividableByFive
{
    [TestFixture]
    public class When_Matching : Match_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void Should_Return_False()
        {
            Assert.IsFalse(Returned);
        }
    }
}
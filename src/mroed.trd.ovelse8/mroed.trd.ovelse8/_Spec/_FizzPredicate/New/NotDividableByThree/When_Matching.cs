using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse8._Spec._FizzPredicate.New.NotDividableByThree
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
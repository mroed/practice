using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse4._Spec._FizzPredicate.NotDividableByThree
{
    [TestFixture]
    public class WhenMatching
    {
        private readonly FizzPredicate _sut = new FizzPredicate();
        private Counter _counterMock;

        [TestFixtureSetUp]
        public void Setup()
        {
            _counterMock = MockRepository.GenerateStrictMock<Counter>();
            _counterMock.Stub(x => x.Value).Return(2);
        }

        [Test]
        public void Should_Return_False()
        {
            Assert.IsFalse(_sut.Matches(_counterMock));
        }
    }
}
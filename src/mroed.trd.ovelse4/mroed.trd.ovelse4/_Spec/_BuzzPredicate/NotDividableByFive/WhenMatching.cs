using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse4._Spec._BuzzPredicate.NotDividableByFive
{
    [TestFixture]
    public class WhenMatching
    {
        private readonly BuzzPredicate _sut = new BuzzPredicate();
        private Counter _counter;

        [TestFixtureSetUp]
        public void Setup()
        {
            _counter = MockRepository.GenerateStrictMock<Counter>();
            _counter.Stub(x => x.Value).Return(4);
        }

        [Test]
        public void Should_Return_False()
        {
            Assert.IsFalse(_sut.Matches(_counter));
        }
    }
}
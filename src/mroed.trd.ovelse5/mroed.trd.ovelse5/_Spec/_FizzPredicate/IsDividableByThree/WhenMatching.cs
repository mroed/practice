using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse5._Spec._FizzPredicate.IsDividableByThree
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
            _counterMock.Stub(x => x.Value).Return(3);
        }

        [Test]
        public void Should_Return_True()
        {
            Assert.IsTrue(_sut.Matches(_counterMock));
        }
    }
}
using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse4._Spec._FizzBuzzPredicate.FizzNotBuzz
{
    [TestFixture]
    public class WhenMatching
    {
        private FizzBuzzPredicate _sut;
        private FizzPredicate _fizzPredicateMock;
        private BuzzPredicate _buzzPredicateMock;
        private Counter _counterMock;

        [TestFixtureSetUp]
        public void Setup()
        {
            _fizzPredicateMock = MockRepository.GenerateStrictMock<FizzPredicate>();
            _buzzPredicateMock = MockRepository.GenerateStrictMock<BuzzPredicate>();
            _counterMock = MockRepository.GenerateStrictMock<Counter>();
            _sut = new FizzBuzzPredicate(_fizzPredicateMock, _buzzPredicateMock);
            _fizzPredicateMock.Stub(x => x.Matches(_counterMock)).Return(true);
            _buzzPredicateMock.Stub(x => x.Matches(_counterMock)).Return(false);
        }
        
        [Test]
        public void Will_Return_True()
        {
            Assert.IsTrue(_sut.Matches(_counterMock));
        }
    }
}
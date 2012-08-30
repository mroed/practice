using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse4._Spec._FizzBuzzPrinter.FizzAndBuzz
{
    [TestFixture]
    public class WhenPrinting
    {
        private FizzBuzzPrinter _sut;
        private Counter _counterMock;
        private BuzzPredicate _buzzPredicateMock;
        private FizzPredicate _fizzPredicateMock;

        [TestFixtureSetUp]
        public void Setup()
        {
            _counterMock = MockRepository.GenerateStrictMock<Counter>();
            _buzzPredicateMock = MockRepository.GenerateStrictMock<BuzzPredicate>();
            _fizzPredicateMock = MockRepository.GenerateStrictMock<FizzPredicate>();
            _sut = new FizzBuzzPrinter(_fizzPredicateMock, _buzzPredicateMock);
            _buzzPredicateMock.Stub(x => x.Matches(_counterMock)).Return(true);
            _fizzPredicateMock.Stub(x => x.Matches(_counterMock)).Return(true);
        }

        [Test]
        public void Should_Return_FizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", _sut.Print(_counterMock));
        }
         
    }
}
using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse4._Spec._FizzBuzzPrinter.BuzzNotFizz
{
    [TestFixture]
    public class WhenPrinting
    {
        private FizzBuzzPrinter _sut;
        private FizzPredicate _fizzPredicateMock;
        private BuzzPredicate _buzzPredicateMock;
        private Counter _counterMock;

        [TestFixtureSetUp]
        public void Setup()
        {
            _counterMock = MockRepository.GenerateStrictMock<Counter>();
            _fizzPredicateMock = MockRepository.GenerateStrictMock<FizzPredicate>();
            _buzzPredicateMock = MockRepository.GenerateStrictMock<BuzzPredicate>();
            _sut = new FizzBuzzPrinter(_fizzPredicateMock, _buzzPredicateMock);
            _fizzPredicateMock.Stub(x => x.Matches(_counterMock)).Return(false);
            _buzzPredicateMock.Stub(x => x.Matches(_counterMock)).Return(true);
        }

        [Test]
        public void Should_Return_Buzz()
        {
            Assert.AreEqual("Buzz", _sut.Print(_counterMock));
        }
    }
}
using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse5._Spec._FizzBuzzPrinter.FizzNotBuzz
{
    [TestFixture]
    public class When_Printing
    {
        private FizzBuzzPrinter _sut;
        private Counter _counterMock;
        private BuzzPredicate _buzzPredicateMock;
        private FizzPredicate _fizzPredicateMock;

        [TestFixtureSetUp]
        public void Setup()
        {
            CreateSut();
            StubPredicates();
        }

        private void CreateSut()
        {
            _counterMock = MockRepository.GenerateStrictMock<Counter>();
            _fizzPredicateMock = MockRepository.GenerateStrictMock<FizzPredicate>();
            _buzzPredicateMock = MockRepository.GenerateStrictMock<BuzzPredicate>();
            _sut = new FizzBuzzPrinter(_fizzPredicateMock, _buzzPredicateMock);
        }

        private void StubPredicates()
        {
            _fizzPredicateMock.Stub(x => x.Matches(_counterMock)).Return(true);
            _buzzPredicateMock.Stub(x => x.Matches(_counterMock)).Return(false);
        }

        [Test]
        public void Should_Return_Fizz()
        {
            Assert.AreEqual("Fizz", _sut.Print(_counterMock));
        }
    }
}
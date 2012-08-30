using System;
using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse5._Spec._FizzBuzz.New.NotFizzBuzz
{
    [TestFixture]
    public class WhenPrinting
    {
        private FizzBuzz _sut;
        private NumericPrinter _numericPrinterMock;
        private FizzBuzzPrinter _fizzBuzzPrinterMock;
        private FizzBuzzPredicate _fizzBuzzPredicateMock;
        private Counter _counterMock;
        private readonly string _expected = Guid.NewGuid().ToString();
        private string _returned;

        [TestFixtureSetUp]
        public void BeforeAll()
        {
            _fizzBuzzPrinterMock = MockRepository.GenerateStrictMock<FizzBuzzPrinter>();
            _numericPrinterMock = MockRepository.GenerateStrictMock<NumericPrinter>();
            _fizzBuzzPredicateMock = MockRepository.GenerateStrictMock<FizzBuzzPredicate>();
            _counterMock = MockRepository.GenerateMock<Counter>();
            _sut = new FizzBuzz(_numericPrinterMock, _fizzBuzzPrinterMock, _fizzBuzzPredicateMock, _counterMock);
            _fizzBuzzPredicateMock.Stub(x => x.Matches(_counterMock)).Return(false);
            _numericPrinterMock.Stub(x => x.Print(_counterMock)).Return(_expected);

            _returned = _sut.Print();
        }

        [Test]
        public void Does_Increment_First()
        {
            _counterMock.AssertWasCalled(x => x.Increment());
        }

        [Test]
        public void It_Returns_Value_From_Numeric_Printer()
        {
            Assert.AreEqual(_expected, _returned);
        }
    }
}
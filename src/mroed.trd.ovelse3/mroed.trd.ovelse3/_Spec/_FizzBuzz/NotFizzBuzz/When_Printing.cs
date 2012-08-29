using System;
using NUnit.Framework;

namespace mroed.trd.ovelse3._Spec._FizzBuzz.NotFizzBuzz
{
    [TestFixture]
    public class When_Printing
    {
        private FizzBuzz _sut;
        private readonly NumericPrinterFake _numericPrinter = new NumericPrinterFake();
        private readonly FizzBuzzPredicateFake _fizzBuzzPredicate = new FizzBuzzPredicateFake();
        private readonly FizzBuzzPrinterFake _fizzBuzzPrinter = new FizzBuzzPrinterFake();
        private readonly CounterFake _counterFake = new CounterFake();
        private readonly string _expected = Guid.NewGuid().ToString();
        private string _returned;

        [TestFixtureSetUp]
        public void BeforeAll()
        {
            _sut = new FizzBuzz(_numericPrinter, _fizzBuzzPrinter, _fizzBuzzPredicate, _counterFake);

            _fizzBuzzPredicate.MatchesShouldReturn(false, _counterFake);
            _fizzBuzzPrinter.PrintShouldReturn(_expected, _counterFake);
            _numericPrinter.PrintShouldReturn(_expected, _counterFake);
            _returned = _sut.Print();
        }

        [Test]
        public void Does_Increment_First()
        {
            Assert.AreEqual(1, _counterFake.Value);
        }

        [Test]
        public void It_Returns_Value_From_Numeric_Printer()
        {
            Assert.AreEqual(_expected, _returned);
        }
    }
}
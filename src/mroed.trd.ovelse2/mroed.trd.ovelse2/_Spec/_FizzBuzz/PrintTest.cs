using System;
using NUnit.Framework;

namespace mroed.trd.ovelse2._Spec._FizzBuzz
{
    [TestFixture]
    public class PrintTest
    {
        private FizzBuzz _sut;
        private readonly NumericPrinterFake _numericPrinter = new NumericPrinterFake();
        private readonly FizzBuzzPredicateFake _fizzBuzzPredicate = new FizzBuzzPredicateFake();
        private readonly FizzBuzzPrinterFake _fizzBuzzPrinter = new FizzBuzzPrinterFake();


        [TestFixtureSetUp]
        public void Setup()
        {
            _sut = new FizzBuzz(_numericPrinter, _fizzBuzzPrinter, _fizzBuzzPredicate);
        }

        [Test]
        public void It_Returns_Value_From_Numeric_Printer_Given_Not_FizzBuzz()
        {
            var expected = Guid.NewGuid().ToString();
            _fizzBuzzPredicate.MatchesShouldReturn(false, 1);
            _numericPrinter.PrintShouldReturn(expected, 1);
            Assert.AreEqual(expected, _sut.Print());
        }

        [Test]
        public void It_Returns_Value_From_FizzBuzz_Printer_Given_FizzBuzz()
        {
            var expected = Guid.NewGuid().ToString();
            _fizzBuzzPredicate.MatchesShouldReturn(true, 1);
            _fizzBuzzPrinter.PrintShouldReturn(expected, 1);
            Assert.AreEqual(expected, _sut.Print());
        }

        [Test]
        public void It_Returns_Value_From_FizzBuzz_Printer_Given_FizzBuzz_When_Ran_Twice()
        {
            _fizzBuzzPredicate.MatchesShouldReturn(true, 1);
            _fizzBuzzPrinter.PrintShouldReturn(null, 1);
            _sut.Print();
            var expected = Guid.NewGuid().ToString();
            _fizzBuzzPredicate.MatchesShouldReturn(true, 2);
            _fizzBuzzPrinter.PrintShouldReturn(expected, 2);
            Assert.AreEqual(expected, _sut.Print());
        }

        [Test]
        public void It_Returns_Value_From_Numeric_Printer_Given_Not_FizzBuzz_When_Ran_Twice()
        {
            _fizzBuzzPredicate.MatchesShouldReturn(false, 1);
            _numericPrinter.PrintShouldReturn(null, 1);
            _sut.Print();
            var expected = Guid.NewGuid().ToString();
            _fizzBuzzPredicate.MatchesShouldReturn(false, 2);
            _numericPrinter.PrintShouldReturn(expected, 2);
            Assert.AreEqual(expected, _sut.Print());
        }
    }
}
using System;
using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse4._Spec._FizzBuzz.IsFizzBuzz
{
    [TestFixture]
    public class WhenPrinting
    {
        private FizzBuzz _sut;
        private NumericPrinter _numericPrinter;
        private FizzBuzzPredicate _fizzBuzzPredicate;
        private FizzBuzzPrinter _fizzBuzzPrinter;
        private Counter _counter;
        private readonly string _expected = Guid.NewGuid().ToString();
        private string _returned;

        [TestFixtureSetUp]
        public void BeforeAll()
        {
            _numericPrinter = MockRepository.GenerateStrictMock<NumericPrinter>();
            _fizzBuzzPredicate = MockRepository.GenerateStrictMock<FizzBuzzPredicate>();
            _fizzBuzzPrinter = MockRepository.GenerateStrictMock<FizzBuzzPrinter>();
            _counter = MockRepository.GenerateMock<Counter>();
            _sut = new FizzBuzz(_numericPrinter, _fizzBuzzPrinter, _fizzBuzzPredicate, _counter);
            _fizzBuzzPredicate.Stub(x => x.Matches(_counter)).Return(true);
            _fizzBuzzPrinter.Stub(x => x.Print(_counter)).Return(_expected);
            _returned = _sut.Print();
        }

        [Test]
        public void Does_Increment_First()
        {
            _counter.AssertWasCalled(x => x.Increment());
        }

        [Test]
        public void It_Returns_Value_From_FizzBuzzPrinter()
        {
            Assert.AreEqual(_expected, _returned);
        }
    }
}
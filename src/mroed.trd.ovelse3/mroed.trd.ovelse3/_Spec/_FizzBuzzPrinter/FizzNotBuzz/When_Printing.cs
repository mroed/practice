using NUnit.Framework;
using mroed.trd.ovelse3._Spec._FizzBuzz;

namespace mroed.trd.ovelse3._Spec._FizzBuzzPrinter.FizzNotBuzz
{
    [TestFixture]
    public class When_Printing
    {
        private FizzBuzzPrinter _sut;
        private readonly FizzPredicateFake _fizzPredicate = new FizzPredicateFake();
        private readonly BuzzPredicateFake _buzzPredicate = new BuzzPredicateFake();
        private readonly CounterFake _counter = new CounterFake();

        [TestFixtureSetUp]
        public void Setup()
        {
            _sut = new FizzBuzzPrinter(_fizzPredicate, _buzzPredicate);
        }

        public void SetCounterValue(int value)
        {
            _counter.Value = value;
        }

        [Test]
        public void Should_Return_Fizz()
        {
            SetCounterValue(1);
            _fizzPredicate.MatchesShouldReturn(true, _counter);
            _buzzPredicate.MatchesShouldReturn(false, _counter);
            Assert.AreEqual("Fizz", _sut.Print(_counter));
        }
    }
}
using System;
using NUnit.Framework;
using mroed.trd.ovelse3._Spec._FizzBuzz;

namespace mroed.trd.ovelse3._Spec._FizzBuzzPrinter.FizzAndBuzz
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

        [Test]
        public void Should_Return_FizzBuzz()
        {
            _counter.Value = 1;
            _fizzPredicate.MatchesShouldReturn(true, _counter);
            _buzzPredicate.MatchesShouldReturn(true, _counter);

            Assert.AreEqual("FizzBuzz", _sut.Print(_counter));
        }
         
    }
}
using System;
using NUnit.Framework;
using mroed.trd.ovelse3._Spec._FizzBuzz;
using mroed.trd.ovelse3._Spec._FizzBuzzPrinter;

namespace mroed.trd.ovelse3._Spec._FizzBuzzPredicate
{
    [TestFixture]
    public class PredicateTest
    {
        private FizzBuzzPredicate _sut;
        private readonly FizzPredicateFake _fizzPredicate = new FizzPredicateFake();
        private readonly BuzzPredicateFake _buzzPredicate = new BuzzPredicateFake();
        private readonly CounterFake _counter = new CounterFake();

        [TestFixtureSetUp]
        public void Setup()
        {
            _sut = new FizzBuzzPredicate(_fizzPredicate, _buzzPredicate);
            _counter.Value = 1;
        }
        
        [Test]
        public void Will_Return_False_When_FizzPredicate_And_BuzzPredicate_Are_False()
        {
            _fizzPredicate.MatchesShouldReturn(false, _counter);
            _buzzPredicate.MatchesShouldReturn(false, _counter);
            Assert.AreEqual(false, _sut.Matches(_counter));
        }

        [Test]
        public void Will_Return_True_When_FizzPredicate_And_Buzzpredicate_Are_True()
        {
            _fizzPredicate.MatchesShouldReturn(true, _counter);
            _buzzPredicate.MatchesShouldReturn(true, _counter);
            Assert.AreEqual(true, _sut.Matches(_counter));
        }

        [Test]
        public void Will_Return_True_When_FizzPredicate_Is_True_And_BuzzPredicate_Is_False()
        {
            _fizzPredicate.MatchesShouldReturn(true, _counter);
            _buzzPredicate.MatchesShouldReturn(false, _counter);
            Assert.AreEqual(true, _sut.Matches(_counter));
        }

        [Test]
        public void Will_Return_True_When_FizzPredicate_Is_False_And_BuzzPredicate_Is_True()
        {
            _fizzPredicate.MatchesShouldReturn(false, _counter);
            _buzzPredicate.MatchesShouldReturn(true, _counter);
            Assert.AreEqual(true, _sut.Matches(_counter));
        }
    }
}
using System;
using NUnit.Framework;
using mroed.trd.ovelse3._Spec._FizzBuzzPrinter;

namespace mroed.trd.ovelse3._Spec._FizzBuzzPredicate
{
    [TestFixture]
    public class PredicateTest
    {
        private FizzBuzzPredicate _sut;
        private readonly FizzPredicateFake _fizzPredicate = new FizzPredicateFake();
        private readonly BuzzPredicateFake _buzzPredicate = new BuzzPredicateFake();

        [TestFixtureSetUp]
        public void Setup()
        {
            _sut = new FizzBuzzPredicate(_fizzPredicate, _buzzPredicate);
        }
        
        [Test]
        public void Will_Return_False_When_FizzPredicate_And_BuzzPredicate_Are_False()
        {
            _fizzPredicate.MatchesShouldReturn(false, 1);
            _buzzPredicate.MatchesShouldReturn(false, 1);
            Assert.AreEqual(false, _sut.Matches(1));
        }

        [Test]
        public void Will_Return_True_When_FizzPredicate_And_Buzzpredicate_Are_True()
        {
            _fizzPredicate.MatchesShouldReturn(true, 1);
            _buzzPredicate.MatchesShouldReturn(true, 1);
            Assert.AreEqual(true, _sut.Matches(1));
        }

        [Test]
        public void Will_Return_True_When_FizzPredicate_Is_True_And_BuzzPredicate_Is_False()
        {
            _fizzPredicate.MatchesShouldReturn(true, 1);
            _buzzPredicate.MatchesShouldReturn(false, 1);
            Assert.AreEqual(true, _sut.Matches(1));
        }

        [Test]
        public void Will_Return_True_When_FizzPredicate_Is_False_And_BuzzPredicate_Is_True()
        {
            _fizzPredicate.MatchesShouldReturn(false, 1);
            _buzzPredicate.MatchesShouldReturn(true, 1);
            Assert.AreEqual(true, _sut.Matches(1));
        }
    }
}
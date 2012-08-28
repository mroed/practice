using NUnit.Framework;
using mroed.trd.ovelse2._Spec._FizzBuzz;

namespace mroed.trd.ovelse2._Spec._FizzBuzzPrinter.FizzNotBuzz
{
    [TestFixture]
    public class When_Printing
    {
        private FizzBuzzPrinter _sut;
        private readonly FizzPredicateFake _fizzPredicate = new FizzPredicateFake();
        private readonly BuzzPredicateFake _buzzPredicate = new BuzzPredicateFake();

        [TestFixtureSetUp]
        public void Setup()
        {
            _fizzPredicate.MatchesShouldReturn(true, 1);
            _buzzPredicate.MatchesShouldReturn(false, 1);
            
            _sut = new FizzBuzzPrinter(_fizzPredicate, _buzzPredicate);
        }

        [Test]
        public void Should_Return_Fizz()
        {
            Assert.AreEqual("Fizz", _sut.Print(1));
        }
    }
}
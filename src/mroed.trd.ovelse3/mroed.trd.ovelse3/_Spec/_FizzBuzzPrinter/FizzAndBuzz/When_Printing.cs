using NUnit.Framework;

namespace mroed.trd.ovelse3._Spec._FizzBuzzPrinter.FizzAndBuzz
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
            _buzzPredicate.MatchesShouldReturn(true, 1);
            
            _sut = new FizzBuzzPrinter(_fizzPredicate, _buzzPredicate);
        }

        [Test]
        public void Should_Return_FizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", _sut.Print(1));
        }
         
    }
}
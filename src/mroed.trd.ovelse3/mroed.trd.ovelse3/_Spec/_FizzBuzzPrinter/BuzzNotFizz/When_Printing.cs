using NUnit.Framework;

namespace mroed.trd.ovelse3._Spec._FizzBuzzPrinter.BuzzNotFizz
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
        public void Should_Return_Buzz()
        {
            _fizzPredicate.MatchesShouldReturn(false, _counter);
            _buzzPredicate.MatchesShouldReturn(true, _counter);

            Assert.AreEqual("Buzz", _sut.Print(_counter));
        }
    }
}
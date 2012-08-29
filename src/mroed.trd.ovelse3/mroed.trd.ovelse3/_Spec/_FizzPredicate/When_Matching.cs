using NUnit.Framework;

namespace mroed.trd.ovelse3._Spec._FizzPredicate
{
    [TestFixture]
    public class When_Matching
    {
        private readonly FizzPredicate _sut = new FizzPredicate();
        private readonly CounterFake _counter = new CounterFake();

        public void SetCounterValue(int value)
        {
            _counter.SetValue(value);
        }

        [Test]
        public void Should_Return_True_When_Given_Number_Divisible_By_Three()
        {
            SetCounterValue(3);
            Assert.AreEqual(true, _sut.Matches(_counter));
        }

        [Test]
        public void Should_Return_False_When_Given_Number_Is_Not_Dividible_By_Three()
        {
            SetCounterValue(2);
            Assert.AreEqual(false, _sut.Matches(_counter));
        }
    }
}
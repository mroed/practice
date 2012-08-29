using System;
using NUnit.Framework;

namespace mroed.trd.ovelse3._Spec._BuzzPredicate
{
    [TestFixture]
    public class When_Matching
    {
        private readonly BuzzPredicate _sut = new BuzzPredicate();
        private readonly CounterFake _counter = new CounterFake();

        public void SetCounterValue(int value)
        {
            _counter.SetValue(value);
        }

        [Test]
        public void Should_Return_True_When_Divisible_By_Five()
        {
            SetCounterValue(5);
            Assert.AreEqual(true, _sut.Matches(_counter));
        }

        [Test]
        public void Should_Return_False_When_Not_Divisible_By_Five()
        {
            SetCounterValue(4);
            Assert.AreEqual(false, _sut.Matches(_counter));
        }
    }
}
using System;
using NUnit.Framework;

namespace mroed.trd.ovelse3._Spec._BuzzPredicate
{
    [TestFixture]
    public class When_Matching
    {
        private readonly BuzzPredicate _sut = new BuzzPredicate();
        private readonly Counter _counter = new Counter();

        public void SetCounterValue(int value)
        {
            _counter.Value = value;
        }

        [Test]
        public void Should_Return_True_When_Divisible_By_Five_Using_Counter()
        {
            SetCounterValue(5);
            Assert.AreEqual(true, _sut.Matches(_counter));
        }

        [Test]
        public void Should_Return_False_When_Not_Divisible_By_Five_Using_Counter()
        {
            SetCounterValue(4);
            Assert.AreEqual(false, _sut.Matches(_counter));
        }
    }
}
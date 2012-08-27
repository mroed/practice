using System;
using NUnit.Framework;

namespace mroed.trd.ovelse2._Spec._FizzBuzzPredicate
{
    [TestFixture]
    public class PredicateTest
    {
        private readonly FizzBuzzPredicate _sut = new FizzBuzzPredicate();

        [Test]
        public void It_Will_Return_False_When_Number_Is_Not_Divisible_With_Three_Or_Five_When_Given_One()
        {
            Assert.AreEqual(false, _sut.Matches(1));
        }

        [Test]
        public void It_Will_Return_False_When_Number_Is_Not_Divisible_With_Three_Or_Five_When_Given_Two()
        {
            Assert.AreEqual(false, _sut.Matches(2));
        }

        [Test]
        public void It_Will_Return_True_When_Number_Is_Divisible_With_Three_Or_Five_When_Given_Three()
        {
            Assert.AreEqual(true, _sut.Matches(3));
        }

        [Test]
        public void It_Will_Return_False_When_Number_Is_Not_Divisible_With_Three_Or_Five_When_Given_Four()
        {
            Assert.AreEqual(false, _sut.Matches(4));
        }

        [Test]
        public void It_Will_Return_True_When_Number_Is_Divisible_With_Three_Or_Five_When_Given_Five()
        {
            Assert.AreEqual(true, _sut.Matches(5));
        }
    }
}
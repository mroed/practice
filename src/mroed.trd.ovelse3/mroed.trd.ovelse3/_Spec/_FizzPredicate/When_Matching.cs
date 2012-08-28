using NUnit.Framework;

namespace mroed.trd.ovelse3._Spec._FizzPredicate
{
    [TestFixture]
    public class When_Matching
    {
        private FizzPredicate _sut = new FizzPredicate();

        [Test]
        public void Should_Return_True_When_Given_Number_Divisible_By_Three()
        {
            Assert.AreEqual(true, _sut.Matches(3));
        }

        [Test]
        public void Should_Return_False_When_Given_Number_Is_Not_Dividible_By_Three()
        {
            Assert.AreEqual(false, _sut.Matches(2));
        }
    }
}
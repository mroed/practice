using NUnit.Framework;

namespace mroed.trd.ovelse2._Spec._BuzzPredicate
{
    [TestFixture]
    public class When_Matching
    {
        private readonly BuzzPredicate _sut = new BuzzPredicate();

        [Test]
        public void Should_Return_True_When_Divisible_By_Five()
        {
            Assert.AreEqual(true, _sut.Matches(5));
        }

        [Test]
        public void Should_Return_False_When_Not_Divisible_By_Five()
        {
            Assert.AreEqual(false, _sut.Matches(4));
        }
    }
}
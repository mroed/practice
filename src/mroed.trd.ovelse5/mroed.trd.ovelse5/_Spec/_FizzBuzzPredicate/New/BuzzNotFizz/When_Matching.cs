using NUnit.Framework;

namespace mroed.trd.ovelse5._Spec._FizzBuzzPredicate.New.BuzzNotFizz
{
    [TestFixture]
    public class When_Matching : Match_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }
        
        [Test]
        public void Will_Return_True()
        {
            Assert.IsTrue(Returned);
        }
    }
}
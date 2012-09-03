using NUnit.Framework;

namespace mroed.trd.ovelse8._Spec._FizzBuzzPredicate.New.FizzNotBuzz
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
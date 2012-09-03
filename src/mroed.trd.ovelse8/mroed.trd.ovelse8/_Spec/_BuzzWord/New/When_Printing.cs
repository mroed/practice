using NUnit.Framework;

namespace mroed.trd.ovelse8._Spec._BuzzWord.New
{
    [TestFixture]
    public class When_Printing : Print_Act
    {
        [TestFixtureSetUp]
        public void BeforeAll()
        {
            Arrange();
            Act();
        }

        [Test]
        public void Should_Return_Buzz()
        {
            Assert.AreEqual(Expected, Returned);
        }
         
    }
}
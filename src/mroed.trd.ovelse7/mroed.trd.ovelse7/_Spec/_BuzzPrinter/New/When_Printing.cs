using NUnit.Framework;

namespace mroed.trd.ovelse7._Spec._BuzzPrinter.New
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
        public void Should_Return_Expected_From_WordPrinter()
        {
            Assert.AreEqual(Expected, Returned);
        }
    }
}
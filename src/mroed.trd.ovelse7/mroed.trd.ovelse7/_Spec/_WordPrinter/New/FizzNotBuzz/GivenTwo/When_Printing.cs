using NUnit.Framework;

namespace mroed.trd.ovelse7._Spec._WordPrinter.New.FizzNotBuzz.GivenTwo
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
        public void Should_Return_Fizz()
        {
            Assert.AreEqual("Fizz 2 times!", Returned);
        }
         
    }
}
using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse5._Spec._FizzBuzzPrinter.New.FizzNotBuzz
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
            Assert.AreEqual("Fizz", Returned);
        }
    }
}
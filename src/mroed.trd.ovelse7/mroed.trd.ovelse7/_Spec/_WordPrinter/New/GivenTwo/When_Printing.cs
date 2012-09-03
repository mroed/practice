using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse7._Spec._WordPrinter.New.GivenTwo
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
        public void It_Should_Increment_First()
        {
            Counter.AssertWasCalled(x => x.Increment());
        }

        [Test]
        public void Should_Return_Fizz()
        {
            Assert.AreEqual("Fizz 2 times!", Returned);
        }
         
    }
}
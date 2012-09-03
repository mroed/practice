using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse8._Spec._WordPrinter.New.GivenOne
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
            Assert.AreEqual("Buzz", Returned);
        }
         
    }
}
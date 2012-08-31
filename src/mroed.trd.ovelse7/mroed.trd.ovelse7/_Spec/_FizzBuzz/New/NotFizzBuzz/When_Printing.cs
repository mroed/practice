using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse7._Spec._FizzBuzz.New.NotFizzBuzz
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
        public void Does_Increment_First()
        {
            Counter.AssertWasCalled(x => x.Increment());
        }

        [Test]
        public void It_Returns_Value_From_Numeric_Printer()
        {
            Assert.AreEqual(Expected, Returned);
        }
    }
}
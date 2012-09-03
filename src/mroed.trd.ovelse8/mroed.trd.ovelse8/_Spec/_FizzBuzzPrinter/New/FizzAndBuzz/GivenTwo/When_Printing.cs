using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse8._Spec._FizzBuzzPrinter.New.FizzAndBuzz.GivenTwo
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

        //[Test]
        //public void It_Should_Increment_First()
        //{
        //    FizzBuzzCounter.AssertWasCalled(x => x.Increment());
        //}

        [Test]
        public void Should_Return_FizzBuzz()
        {
            Assert.AreEqual(Expected, Returned);
        }
    }
}
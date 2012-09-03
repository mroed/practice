using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse8._Spec._FizzBuzzPrinter.New.FizzAndBuzz.GivenOne
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
        public void Should_Return_FizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", Returned);
        }
    }
}
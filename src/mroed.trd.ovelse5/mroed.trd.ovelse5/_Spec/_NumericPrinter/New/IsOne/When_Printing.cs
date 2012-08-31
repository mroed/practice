using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse5._Spec._NumericPrinter.New.IsOne
{
    [TestFixture]
    public class When_Printing : Print_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void Should_Return_One_Given_One()
        {
            Assert.AreEqual("1", Returned);
        }
    }
}
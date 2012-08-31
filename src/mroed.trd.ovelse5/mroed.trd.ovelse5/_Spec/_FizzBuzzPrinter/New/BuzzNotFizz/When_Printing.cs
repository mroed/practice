using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse5._Spec._FizzBuzzPrinter.New.BuzzNotFizz
{
    [TestFixture]
    public class When_Printing : Printing_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void Should_Return_Buzz()
        {
            Assert.AreEqual("Buzz", Sut.Print(Counter));
        }
    }
}
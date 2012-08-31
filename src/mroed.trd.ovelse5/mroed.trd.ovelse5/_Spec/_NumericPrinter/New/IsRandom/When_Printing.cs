using System;
using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse5._Spec._NumericPrinter.New.IsRandom
{
    [TestFixture]
    public class When_Printing : Printing_Act
    {
        [TestFixtureSetUp]
        public void BeforeAll()
        {
            Arrange();
            Act();
        }

        [Test]
        public void Should_Return_Same_Number_Given_Random()
        {
            Assert.AreEqual(Convert.ToString(RandomNumber), Sut.Print(Counter));
        }


    }
}
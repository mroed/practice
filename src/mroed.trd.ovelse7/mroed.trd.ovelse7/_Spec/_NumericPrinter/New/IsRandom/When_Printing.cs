using System;
using NUnit.Framework;

namespace mroed.trd.ovelse7._Spec._NumericPrinter.New.IsRandom
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
        public void Should_Return_Same_Number_Given_Random()
        {
            Assert.AreEqual(Convert.ToString(RandomNumber), Returned);
        }


    }
}
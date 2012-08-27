using System;
using NUnit.Framework;

namespace mroed.trd.ovelse2._Spec._NumericPrinter
{
    [TestFixture]
    public class NumericNumberTest
    {
        private NumericPrinter _sut = new NumericPrinter();

        [Test]
        public void Should_Return_Same_Number_As_Given()
        {
            Assert.AreEqual("1", _sut.Print(1));
            
        }

        [Test]
        public void Should_Return_Same_Number_As_Given_No_Matter_What()
        {
            Random random = new Random();
            var _randomNumber = random.Next();
            Assert.AreEqual(Convert.ToString(_randomNumber), _sut.Print(_randomNumber));
        }
    }
}
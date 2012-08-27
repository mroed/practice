using System;
using NUnit.Framework;

namespace mroed.trd.ovelse2._Spec._FizzBuzzPrinter
{
    [TestFixture]
    public class FizzBuzzPrinterTest
    {
        private FizzBuzzPrinter _sut = new FizzBuzzPrinter();

        [Test]
        public void It_Returns_Fizz_When_Divisible_By_Three()
        {
            //var _rand = new Random();
            //var _random = _rand.Next() * 3;

            Assert.AreEqual("Fizz", _sut.Print(3));
        }

        

        [Test]
        public void It_Returns_Buzz_When_Divisible_By_Five()
        {
            Assert.AreEqual("Buzz", _sut.Print(5));
        }

        [Test]
        public void It_Returns_FizzBuzz_When_Divisible_By_Three_And_Five()
        {
            Assert.AreEqual("FizzBuzz", _sut.Print(15));
        }


         
    }
}
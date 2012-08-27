using NUnit.Framework;

namespace mroed.trd.ovelse1._Spec._FizzBuzz
{
    [TestFixture]
    public class When_Sending_Number
    {
        private readonly FizzBuzzWithInput _fizzBuzzWithInput = new FizzBuzzWithInput();

        [Test]
        public void PrintOne()
        {
            var result = _fizzBuzzWithInput.PrintNumber(1);
            Assert.AreEqual("1", result);
        }

        [Test]
        public void PrintTwo()
        {
            var result = _fizzBuzzWithInput.PrintNumber(2);
            Assert.AreEqual("2", result);
        }

        [Test]
        public void PrintFizzWhenNumberMultipleOfThree()
        {
            Assert.AreEqual("Fizz", _fizzBuzzWithInput.PrintNumber(3));
            Assert.AreEqual("Fizz", _fizzBuzzWithInput.PrintNumber(6));
            Assert.AreEqual("Fizz", _fizzBuzzWithInput.PrintNumber(9));
            Assert.AreEqual("Fizz", _fizzBuzzWithInput.PrintNumber(12));
        }

        [Test]
        public void PrintFour()
        {
            var result = _fizzBuzzWithInput.PrintNumber(4);
            Assert.AreEqual("4", result);
        }

        [Test]
        public void PrintBuzzWhenNumberMultipleOfFive()
        {
            Assert.AreEqual("Buzz", _fizzBuzzWithInput.PrintNumber(5));
            Assert.AreEqual("Buzz", _fizzBuzzWithInput.PrintNumber(10));
        }

        [Test]
        public void PrintSeven()
        {
            var result = _fizzBuzzWithInput.PrintNumber(7);
            Assert.AreEqual("7", result);
        }

        [Test]
        public void PrintEight()
        {
            var result = _fizzBuzzWithInput.PrintNumber(8);
            Assert.AreEqual("8", result);
        }

        [Test]
        public void PrintEleven()
        {
            var result = _fizzBuzzWithInput.PrintNumber(11);
            Assert.AreEqual("11", result);
        }

        [Test]
        public void PrintThirteen()
        {
            var result = _fizzBuzzWithInput.PrintNumber(13);
            Assert.AreEqual("13", result);
        }

        [Test]
        public void PrintFourteen()
        {
            var result = _fizzBuzzWithInput.PrintNumber(14);
            Assert.AreEqual("14", result);
        }

        [Test]
        public void PrintFizzBuzzWhenNumberMultipleOfThreeAndFive()
        {
            Assert.AreEqual("FizzBuzz", _fizzBuzzWithInput.PrintNumber(15));
        }
    }
}
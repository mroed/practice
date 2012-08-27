using NUnit.Framework;

namespace mroed.trd.ovelse1._Spec._FizzBuzz
{
    [TestFixture]
    public class When_Printing_Array
    {
        private readonly string[] _printResults = new string[15];
        
        [TestFixtureSetUp]
        public void Setup()
        {
            var sut = new FizzBuzz();
            for (int i = 0; i < _printResults.Length; i++)
            {
                _printResults[i] = sut.Print();
            }
        }
        
        [Test]
        public void PrintOne()
        {
            Assert.AreEqual("1", _printResults[0]);
        }

        [Test]
        public void PrintTwo()
        {
            Assert.AreEqual("2", _printResults[1]);
        }

        [Test]
        public void PrintThreeShouldReturnFizz()
        {
            Assert.AreEqual("Fizz", _printResults[2]);
        }

        [Test]
        public void PrintFour()
        {
            Assert.AreEqual("4", _printResults[3]);
        }

        [Test]
        public void PrintFiveShouldReturnBuzz()
        {
            Assert.AreEqual("Buzz", _printResults[4]);
        }

        [Test]
        public void PrintSixShouldReturnFizz()
        {
            Assert.AreEqual("Fizz", _printResults[5]);
        }

        [Test]
        public void PrintSeven()
        {
            Assert.AreEqual("7", _printResults[6]);
        }

        [Test]
        public void PrintEight()
        {
            Assert.AreEqual("8", _printResults[7]);
        }

        [Test]
        public void PrintNineShouldReturnFizz()
        {
            Assert.AreEqual("Fizz", _printResults[8]);
        }

        [Test]
        public void PrintTenShouldReturnBuzz()
        {
            Assert.AreEqual("Buzz", _printResults[9]);
        }

        [Test]
        public void PrintEleven()
        {
            Assert.AreEqual("11", _printResults[10]);
        }

        [Test]
        public void PrintTwelveShouldReturnFizz()
        {
            Assert.AreEqual("Fizz", _printResults[11]);
        }

        [Test]
        public void PrintThirteen()
        {
            Assert.AreEqual("13", _printResults[12]);
        }

        [Test]
        public void PrintFourteen()
        {
            Assert.AreEqual("14", _printResults[13]);
        }

        [Test]
        public void PrintFifteenShouldReturnFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", _printResults[14]);
        }
    }
}
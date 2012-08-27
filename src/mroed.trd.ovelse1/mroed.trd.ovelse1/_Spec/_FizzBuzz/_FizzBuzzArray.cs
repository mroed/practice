using NUnit.Framework;

namespace mroed.trd.ovelse1._Spec._FizzBuzz
{
    [TestFixture]
    public class _FizzBuzzArray
    {
        private readonly string[] printResults = new string[15];
        
        [TestFixtureSetUp]
        public void Setup()
        {
            var sut = new FizzBuzz();
            for (int i = 0; i < printResults.Length; i++)
            {
                printResults[i] = sut.Print();
            }
        }


        [Test]
        public void PrintOne()
        {
            Assert.AreEqual("1", printResults[0]);
        }

        [Test]
        public void PrintTwo()
        {
            Assert.AreEqual("2", printResults[1]);
        }

        [Test]
        public void PrintThreeShouldReturnFizz()
        {
            Assert.AreEqual("Fizz", printResults[2]);
        }

        [Test]
        public void PrintFour()
        {
            Assert.AreEqual("4", printResults[3]);
        }

        [Test]
        public void PrintFiveShouldReturnBuzz()
        {
            Assert.AreEqual("Buzz", printResults[4]);
        }

        [Test]
        public void PrintSixShouldReturnFizz()
        {
            Assert.AreEqual("Fizz", printResults[5]);
        }

        [Test]
        public void PrintSeven()
        {
            Assert.AreEqual("7", printResults[6]);
        }

        [Test]
        public void PrintEight()
        {
            Assert.AreEqual("8", printResults[7]);
        }

        [Test]
        public void PrintNineShouldReturnFizz()
        {
            Assert.AreEqual("Fizz", printResults[8]);
        }

        [Test]
        public void PrintTenShouldReturnBuzz()
        {
            Assert.AreEqual("Buzz", printResults[9]);
        }

        [Test]
        public void PrintEleven()
        {
            Assert.AreEqual("11", printResults[10]);
        }

        [Test]
        public void PrintTwelveShouldReturnFizz()
        {
            Assert.AreEqual("Fizz", printResults[11]);
        }

        [Test]
        public void PrintThirteen()
        {
            Assert.AreEqual("13", printResults[12]);
        }

        [Test]
        public void PrintFourteen()
        {
            Assert.AreEqual("14", printResults[13]);
        }

        [Test]
        public void PrintFifteenShouldReturnFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", printResults[14]);
        }
    }
}
using NUnit.Framework;

namespace mroed.trd.ovelse1._Spec._FizzBuzz
{
    [TestFixture]
    public class When_Using_Internal_PrintMethod_LE
    {
        private string _result;

        private void Print(int numberOfTimes)
        {
            var sut = new FizzBuzz();
            for (int i = 1; i <= numberOfTimes; i++)
            {
                _result = sut.Print();
            }
        }

        [Test]
        public void PrintInMultiplesOfThree()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    continue;
                }
                if (i % 3 == 0)
                {
                    Print(i);
                    Assert.AreEqual("Fizz", _result);
                }
            }
        }

        [Test]
        public void PrintInMultiplesOfFive()
        {
            var sut = new FizzBuzz();
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                if (i % 5 == 0)
                {
                    Print(i);
                    Assert.AreEqual("Buzz", _result);
                }
                
            }
        }


        [Test]
        public void PrintOne()
        {
            Print(1);
            Assert.AreEqual("1", _result);
        }

        [Test]
        public void PrintTwo()
        {
            Print(2);
            Assert.AreEqual("2", _result);
        }

        [Test]
        public void PrintThreeShouldBeFizz()
        {
            Print(3);
            Assert.AreEqual("Fizz", _result);
        }

        [Test]
        public void PrintFour()
        {
            Print(4);
            Assert.AreEqual("4", _result);
        }

        [Test]
        public void PrintFiveShouldBeBuzz()
        {
            Print(5);
            Assert.AreEqual("Buzz", _result);
        }

        [Test]
        public void PrintSixShouldBeFizz()
        {
            Print(6);
            Assert.AreEqual("Fizz", _result);
        }

        [Test]
        public void PrintSeven()
        {
            Print(7);
            Assert.AreEqual("7", _result);
        }

        [Test]
        public void PrintEight()
        {
            Print(8);
            Assert.AreEqual("8", _result);
        }

        [Test]
        public void PrintNineShouldBeFizz()
        {
            Print(9);
            Assert.AreEqual("Fizz", _result);
        }

        [Test]
        public void PrintTenShouldBeBuzz()
        {
            Print(10);
            Assert.AreEqual("Buzz", _result);
        }

        [Test]
        public void PrintEleven()
        {
            Print(11);
            Assert.AreEqual("11", _result);
        }

        [Test]
        public void PrintTwelveShouldBeFizz()
        {
            Print(12);
            Assert.AreEqual("Fizz", _result);
        }

        [Test]
        public void PrintThirteen()
        {
            Print(13);
            Assert.AreEqual("13", _result);
        }

        [Test]
        public void PrintFourteen()
        {
            Print(14);
            Assert.AreEqual("14", _result);
        }

        [Test]
        public void PrintFifteenShouldBeFizzBuzz()
        {
            Print(15);
            Assert.AreEqual("FizzBuzz", _result);
        }
    }
}
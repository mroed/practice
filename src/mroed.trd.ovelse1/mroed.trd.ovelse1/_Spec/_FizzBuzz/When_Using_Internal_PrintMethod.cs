using System;
using NUnit.Framework;

namespace mroed.trd.ovelse1._Spec._FizzBuzz
{
    [TestFixture]
    public class When_Using_Internal_PrintMethod
    {

        public static string SutPrinter(int numberOfTimes)
        {
            var sut = new FizzBuzz();
            var result = "";
            for (int i = 0; i < numberOfTimes; i++)
            {
                result = sut.Print();
            }
            return result;
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
                    Assert.AreEqual("Fizz", SutPrinter(i));
                }
            }
        }
        
        [Test]
        public void PrintInMultiplesOfFive()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                if (i % 5 == 0)
                {
                    Assert.AreEqual("Buzz", SutPrinter(i));
                }
            }
        }

        [Test]
        public void PrintInMultiplesOfThreeAndFive()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Assert.AreEqual("FizzBuzz", SutPrinter(i)); ;
            }
        }

        [Test]
        public void PrintOne()
        {
            Assert.AreEqual("1", SutPrinter(1));
        }

        [Test]
        public void PrintTwo()
        {
            Assert.AreEqual("2", SutPrinter(2));
        }

        [Test]
        public void PrintThree()
        {
            Assert.AreEqual("Fizz", SutPrinter(3));
        }

        [Test]
        public void PrintFour()
        {
            Assert.AreEqual("4", SutPrinter(4));
        }

        [Test]
        public void PrintFive()
        {
            Assert.AreEqual("Buzz", SutPrinter(5));
        }

        [Test]
        public void PrintSix()
        {
            Assert.AreEqual("Fizz", SutPrinter(6));
        }

        [Test]
        public void PrintSeven()
        {
            Assert.AreEqual("7", SutPrinter(7));
        }

        [Test]
        public void PrintEight()
        {
            Assert.AreEqual("8", SutPrinter(8));
        }

        [Test]
        public void PrintNine()
        {
            Assert.AreEqual("Fizz", SutPrinter(9));
        }

        [Test]
        public void PrintTen()
        {
            Assert.AreEqual("Buzz", SutPrinter(10));
        }

        [Test]
        public void PrintEleven()
        {
            Assert.AreEqual("11", SutPrinter(11));
        }

        [Test]
        public void PrintTwelve()
        {
            Assert.AreEqual("Fizz", SutPrinter(12));
        }

        [Test]
        public void PrintThirteen()
        {
            Assert.AreEqual("13", SutPrinter(13));
        }

        [Test]
        public void PrintFourteen()
        {
            Assert.AreEqual("14", SutPrinter(14));
        }

        [Test]
        public void PrintFifteen()
        {
            Assert.AreEqual("FizzBuzz", SutPrinter(15));
        }
    }
}
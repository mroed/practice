using System;
using NUnit.Framework;

namespace mroed.trd.ovelse1._Spec._FizzBuzz
{
    [TestFixture]
    public class _FizzBuzzInternalClass
    {
        [Test]
        public void PrintInMultiplesOfThree()
        {
            //Assert.AreEqual("Fizz", _FizzBuzzSutPrinter.SutPrinter("3"));
            //Assert.AreEqual("Fizz", _FizzBuzzSutPrinter.SutPrinter("6"));
            //Assert.AreEqual("Fizz", _FizzBuzzSutPrinter.SutPrinter("9"));
            //Assert.AreEqual("Fizz", _FizzBuzzSutPrinter.SutPrinter("12"));
            int counter = 0;

            string numberToTest = "";
            for (int i = 1; i < 100; i++)
            {
                counter++;
                //if (i % 3 == 0 && i % 5 == 0)
                //{    
                //    Console.Out.WriteLine("Første if slår inn");
                //    continue;
                //} 
                if (i % 5 == 0)
                {
                    Console.Out.WriteLine("Andre if slår inn");
                    continue;
                }
                if (i % 3 == 0)
                {
                    Console.Out.WriteLine("siste if slår inn, counter før: " + counter);
                    Assert.AreEqual("Fizz", _FizzBuzzSutPrinter.SutPrinter(Convert.ToString(i)));
                    Console.Out.WriteLine("siste if slår inn, counter etter: " + counter);
                }
            }
        }
        
        [Test]
        public void PrintInMultiplesOfFive()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                    continue;
                if (i % 5 == 0)
                    Assert.AreEqual("Buzz", _FizzBuzzSutPrinter.SutPrinter(Convert.ToString(i)));
            }
        }

        [Test]
        public void PrintInMultiplesOfThreeAndFive()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Assert.AreEqual("FizzBuzz", _FizzBuzzSutPrinter.SutPrinter(Convert.ToString(i)));;                    
            }
        }

        [Test]
        public void PrintOne()
        {
            Assert.AreEqual("1", _FizzBuzzSutPrinter.SutPrinter("1"));
        }

        [Test]
        public void PrintTwo()
        {
            Assert.AreEqual("2", _FizzBuzzSutPrinter.SutPrinter("2"));
        }

        [Test]
        public void PrintThree()
        {
            Assert.AreEqual("Fizz", _FizzBuzzSutPrinter.SutPrinter("3"));
        }

        [Test]
        public void PrintFour()
        {
            Assert.AreEqual("4", _FizzBuzzSutPrinter.SutPrinter("4"));
        }

        [Test]
        public void PrintFive()
        {
            Assert.AreEqual("Buzz", _FizzBuzzSutPrinter.SutPrinter("5"));
        }

        [Test]
        public void PrintSix()
        {
            Assert.AreEqual("Fizz", _FizzBuzzSutPrinter.SutPrinter("6"));
        }

        [Test]
        public void PrintSeven()
        {
            Assert.AreEqual("7", _FizzBuzzSutPrinter.SutPrinter("7"));
        }

        [Test]
        public void PrintEight()
        {
            Assert.AreEqual("8", _FizzBuzzSutPrinter.SutPrinter("8"));
        }

        [Test]
        public void PrintNine()
        {
            Assert.AreEqual("Fizz", _FizzBuzzSutPrinter.SutPrinter("9"));
        }

        [Test]
        public void PrintTen()
        {
            Assert.AreEqual("Buzz", _FizzBuzzSutPrinter.SutPrinter("10"));
        }

        [Test]
        public void PrintEleven()
        {
            Assert.AreEqual("11", _FizzBuzzSutPrinter.SutPrinter("11"));
        }

        [Test]
        public void PrintTwelve()
        {
            Assert.AreEqual("Fizz", _FizzBuzzSutPrinter.SutPrinter("12"));
        }

        [Test]
        public void PrintThirteen()
        {
            Assert.AreEqual("13", _FizzBuzzSutPrinter.SutPrinter("13"));
        }

        [Test]
        public void PrintFourteen()
        {
            Assert.AreEqual("14", _FizzBuzzSutPrinter.SutPrinter("14"));
        }

        [Test]
        public void PrintFifteen()
        {
            Assert.AreEqual("FizzBuzz", _FizzBuzzSutPrinter.SutPrinter("15"));
        }
    }

    public class _FizzBuzzSutPrinter
    {
        public static string SutPrinter(string numberOfTimes)
        {
            var sut = new FizzBuzz();
            var result = "";
            for (int i = 0; i < Convert.ToInt32(numberOfTimes); i++)
            {
                result = sut.Print();
            }
            return result;
        }
    }
}
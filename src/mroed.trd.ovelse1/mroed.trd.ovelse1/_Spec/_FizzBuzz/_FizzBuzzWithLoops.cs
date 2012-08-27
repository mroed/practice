using System;
using NUnit.Framework;

namespace mroed.trd.ovelse1._Spec._FizzBuzz
{
    [TestFixture]
    public class _FizzBuzzWithLoops
    {
        [Test]
        public void PrintInMultiplesOfThree()
        {
            var sut = new FizzBuzz();
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 3; j++)
                {
                    sut.Print();   
                }
                Assert.AreEqual("Fizz", sut.Print());   
            }
        }

        [Test]
        public void PrintInMultiplesOfFive()
        {
            var sut = new FizzBuzz();
            for (int i = 1; i < 3; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    sut.Print();
                }
                Assert.AreEqual("Buzz", sut.Print());
            }
        }
        
        
        [Test]
        public void PrintOne()
        {
            var sut = new FizzBuzz();
            Assert.AreEqual("1", sut.Print());
        }

        [Test]
        public void PrintTwo()
        {
            var sut = new FizzBuzz();
            sut.Print();
            Assert.AreEqual("2", sut.Print());
        }

        [Test]
        public void PrintThreeShouldBeFizz()
        {
            var sut = new FizzBuzz();
            sut.Print();
            sut.Print();
            Assert.AreEqual("Fizz", sut.Print());
        }

        [Test]
        public void PrintFour()
        {
            var sut = new FizzBuzz();
            sut.Print();
            sut.Print();
            sut.Print();
            Assert.AreEqual("4", sut.Print());
        }

        [Test]
        public void PrintFiveShouldBeBuzz()
        {
            var sut = new FizzBuzz();
            for (int i = 1; i < 5; i++)
                sut.Print();
            
            Assert.AreEqual("Buzz", sut.Print());
        }

        [Test]
        public void PrintSixShouldBeFizz()
        {
            var sut = new FizzBuzz();
            for (int i = 1; i < 6; i++)
                sut.Print();
            
            Assert.AreEqual("Fizz", sut.Print());
        }

        [Test]
        public void PrintSeven()
        {
            var sut = new FizzBuzz();
            for (int i = 1; i < 7; i++)
                sut.Print();

            Assert.AreEqual("7", sut.Print());
        }

        [Test]
        public void PrintEight()
        {
            var sut = new FizzBuzz();
            for (int i = 1; i < 8; i++)
                sut.Print();

            Assert.AreEqual("8", sut.Print());
        }

        [Test]
        public void PrintNineShouldBeFizz()
        {
            var sut = new FizzBuzz();
            for (int i = 1; i < 9; i++)
                sut.Print();

            Assert.AreEqual("Fizz", sut.Print());
        }

        [Test]
        public void PrintTenShouldBeBuzz()
        {
            var sut = new FizzBuzz();
            for (int i = 1; i < 10; i++)
                sut.Print();

            Assert.AreEqual("Buzz", sut.Print());
        }

        [Test]
        public void PrintEleven()
        {
            var sut = new FizzBuzz();
            for (int i = 1; i < 11; i++)
                sut.Print();

            Assert.AreEqual("11", sut.Print());
        }

        [Test]
        public void PrintTwelveShouldBeFizz()
        {
            var sut = new FizzBuzz();
            for (int i = 1; i < 12; i++)
                sut.Print();

            Assert.AreEqual("Fizz", sut.Print());
        }

        [Test]
        public void PrintThirteen()
        {
            var sut = new FizzBuzz();
            for (int i = 1; i < 13; i++)
                sut.Print();

            Assert.AreEqual("13", sut.Print());
        }

        [Test]
        public void PrintFourteen()
        {
            var sut = new FizzBuzz();
            for (int i = 1; i < 14; i++)
                sut.Print();

            Assert.AreEqual("14", sut.Print());
        }

        [Test]
        public void PrintFifteenShouldBeFizzBuzz()
        {
            var sut = new FizzBuzz();
            for (int i = 1; i < 15; i++)
                sut.Print();

            Assert.AreEqual("FizzBuzz", sut.Print());
        }
    }
}
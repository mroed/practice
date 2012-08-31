using NUnit.Framework;
using Timpex;

namespace mroed.trd.ovelse7._Spec._FizzBuzz
{
    [TestFixture]
    public class IntegrationTest
    {
        private readonly Ioc _ioc = new InversionOfControlContainer();
        private FizzBuzz _sut;
        private readonly string[] _result = new string[15];

        [TestFixtureSetUp]
        public void BeforeAll()
        {
            _sut = _ioc.Resolve<FizzBuzz>();
            for (int i = 1; i <= 15; i++)
            {
                _result[i - 1] = _sut.Print();
            }
        }
         
        private string Result(int index)
        {
            return _result[index - 1];
        }

        [Test]
        public void It_Returns_One()
        {
            Assert.AreEqual("1", Result(1));
        }

        [Test]
        public void It_Returns_Two()
        {
            Assert.AreEqual("2", Result(2));
        }

        [Test]
        public void It_Returns_Fizz_At_3()
        {
            Assert.AreEqual("Fizz", Result(3));
        }

        [Test]
        public void It_Returns_Four()
        {
            Assert.AreEqual("4", Result(4));
        }

        [Test]
        public void It_Returns_Buzz_At_5()
        {
            Assert.AreEqual("Buzz", Result(5));
        }

        [Test]
        public void It_Returns_Fizz_At_6()
        {
            Assert.AreEqual("Fizz 2 times!", Result(6));
        }

        [Test]
        public void It_Returns_Seven()
        {
            Assert.AreEqual("7", Result(7));
        }

        [Test]
        public void It_Returns_Eight()
        {
            Assert.AreEqual("8", Result(8));
        }

        [Test]
        public void It_Returns_Fizz_At_9()
        {
            Assert.AreEqual("Fizz 3 times!", Result(9));
        }

        [Test]
        public void It_Returns_Buzz_At_10()
        {
            Assert.AreEqual("Buzz 2 times!", Result(10));
        }

        [Test]
        public void It_Returns_Eleven()
        {
            Assert.AreEqual("11", Result(11));
        }

        [Test]
        public void It_Returns_Fizz_At_12()
        {
            Assert.AreEqual("Fizz 4 times!", Result(12));
        }

        [Test]
        public void It_Returns_Thirteen()
        {
            Assert.AreEqual("13", Result(13));
        }

        [Test]
        public void It_Returns_Fourteen()
        {
            Assert.AreEqual("14", Result(14));
        }

        [Test]
        public void It_Returns_FizzBuzz_At_15()
        {
            Assert.AreEqual("FizzBuzz", Result(15));
        }
    }
}
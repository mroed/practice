using NUnit.Framework;

namespace mroed.trd.ovelse1._Spec._FizzBuzz
{
    [TestFixture]
    public class _FizzBuzz
    {
        private readonly FizzBuzz _fizzBuzz = new FizzBuzz();

        [Test]
        public void PrintOne()
        {
            var result = _fizzBuzz.Print();

            Assert.AreEqual("1", result);
            //Assert.AreEqual("2", sut.Print());
        }

        [Test]
        public void PrintTwo()
        {
            var result = _fizzBuzz.Print();
          // result = _fizzBuzz.Print();

            Assert.AreEqual("2", result);
        }

        [Test]
        public void PrintThreeFizz()
        {
            var result = _fizzBuzz.Print();
            for (int i = 0; i < 2; i++)
            {
                result = _fizzBuzz.Print();
            }

            Assert.AreEqual("fizz", result);
        }
        
    }
}
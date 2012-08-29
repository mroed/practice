using System;
using NUnit.Framework;
using mroed.trd.ovelse3._Spec._FizzBuzz;

namespace mroed.trd.ovelse3._Spec._NumericPrinter
{
    [TestFixture]
    public class NumericNumberTest
    {
        private NumericPrinter _sut = new NumericPrinter();
        private readonly CounterFake _counter = new CounterFake();

        [Test]
        public void Should_Return_Same_Number_As_Given()
        {
            _counter.Value = 1;
            Assert.AreEqual("1", _sut.Print(_counter));
        }

        [Test]
        public void Should_Return_Same_Number_As_Given_No_Matter_What()
        {
            Random random = new Random();
            var _randomNumber = random.Next();
            _counter.Value = _randomNumber;

            Assert.AreEqual(Convert.ToString(_randomNumber), _sut.Print(_counter));
        }


    }
}
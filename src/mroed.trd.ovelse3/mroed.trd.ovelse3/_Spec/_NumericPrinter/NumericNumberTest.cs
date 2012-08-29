using System;
using NUnit.Framework;

namespace mroed.trd.ovelse3._Spec._NumericPrinter
{
    [TestFixture]
    public class NumericNumberTest
    {
        private readonly NumericPrinter _sut = new NumericPrinter();
        private readonly CounterFake _counter = new CounterFake();

        [Test]
        public void Should_Return_Same_Number_As_Given()
        {
            _counter.SetValue(1);
            Assert.AreEqual("1", _sut.Print(_counter));
        }

        [Test]
        public void Should_Return_Same_Number_As_Given_No_Matter_What()
        {
            var random = new Random();
            var randomNumber = random.Next();
            _counter.SetValue(randomNumber);

            Assert.AreEqual(Convert.ToString(randomNumber), _sut.Print(_counter));
        }


    }
}
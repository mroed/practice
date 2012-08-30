using System;
using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse4._Spec._NumericPrinter.IsRandom
{
    [TestFixture]
    public class NumericNumberTest
    {
        private NumericPrinter _sut;
        private Counter _counterMock;
        

        [SetUp]
        public void Setup()
        {
            _sut = new NumericPrinter();
            _counterMock = MockRepository.GenerateStrictMock<Counter>();
        }

        public void SetCounterValue(int value)
        {
            _counterMock.Stub(x => x.Value).Return(value);          
        }

        [Test]
        public void Should_Return_Same_Number_Given_Random()
        {
            var random = new Random();
            var randomNumber = random.Next();
            SetCounterValue(randomNumber);

            Assert.AreEqual(Convert.ToString(randomNumber), _sut.Print(_counterMock));
        }


    }
}
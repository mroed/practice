using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse5._Spec._NumericPrinter.IsOne
{
    [TestFixture]
    public class WhenPrinting
    {
        private NumericPrinter _sut;
        private Counter _counterMock;

        [TestFixtureSetUp]
        public void Setup()
        {
            _sut = new NumericPrinter();
            _counterMock = MockRepository.GenerateStrictMock<Counter>();
            _counterMock.Stub(x => x.Value).Return(1);
        }

        [Test]
        public void Should_Return_One_Given_One()
        {
            Assert.AreEqual("1", _sut.Print(_counterMock));
        }
    }
}
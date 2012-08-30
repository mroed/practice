using NUnit.Framework;

namespace mroed.trd.ovelse4._Spec._Counter
{
    [TestFixture]
    public class Is_Incrementing
    {
        private Counter _sut;

        [SetUp]
        public void Setup()
        {
             _sut = new Counter();
        }

        public void Increment_Counter(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _sut.Increment();
            }
        }

        [Test]
        public void Counter_Value_Starts_At_0()
        {
            Assert.AreEqual(0, _sut.Value);
        }

        [Test]
        public void Counter_increments_Once()
        {
            Increment_Counter(1);
            Assert.AreEqual(1, _sut.Value);
        }

        [Test]
        public void Counter_increments_25_Times()
        {
            Increment_Counter(25);
            Assert.AreEqual(25, _sut.Value);
        }
    }
}
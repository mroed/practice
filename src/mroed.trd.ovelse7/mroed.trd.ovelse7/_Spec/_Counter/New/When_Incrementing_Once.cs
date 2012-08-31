using NUnit.Framework;

namespace mroed.trd.ovelse7._Spec._Counter.New
{
    [TestFixture]
    public class When_Incrementing_Once : Increment_Act
    {
        [TestFixtureSetUp]
        public void BeforeAll()
        {
            Arrange();
            Act();
        }

        [Test]
        public void Counter_increments_Once()
        {
            Assert.AreEqual(1, Sut.Value);
        }
    }
}
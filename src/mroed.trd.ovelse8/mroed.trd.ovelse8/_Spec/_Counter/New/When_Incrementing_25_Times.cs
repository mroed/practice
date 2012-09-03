using NUnit.Framework;

namespace mroed.trd.ovelse8._Spec._Counter.New
{
    [TestFixture]
    public class When_Incrementing_25_Times : Increment25_Act
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
            Assert.AreEqual(25, Sut.Value);
        }
    }
}
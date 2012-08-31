using NUnit.Framework;

namespace mroed.trd.ovelse5._Spec._Counter
{
    [TestFixture]
    public class When_New : New_Act
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
            Assert.AreEqual(0, Sut.Value);
        }
    }
}
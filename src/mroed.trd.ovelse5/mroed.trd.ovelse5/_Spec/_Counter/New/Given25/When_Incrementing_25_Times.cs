using NUnit.Framework;

namespace mroed.trd.ovelse5._Spec._Counter.New.Given25
{
    [TestFixture]
    public class When_Incrementing_25_Times : Incrementing_Act
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
            Assert.AreEqual(25, Returned.Value);
        }
    }
}
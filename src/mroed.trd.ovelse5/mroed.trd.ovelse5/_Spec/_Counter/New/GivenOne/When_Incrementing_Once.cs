using NUnit.Framework;

namespace mroed.trd.ovelse5._Spec._Counter.New.GivenOne
{
    [TestFixture]
    public class When_Incrementing_Once : Incrementing_Act
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
            Assert.AreEqual(1, Returned.Value);
        }
    }
}
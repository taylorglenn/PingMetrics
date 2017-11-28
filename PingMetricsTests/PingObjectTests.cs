using NUnit.Framework;

namespace PingMetrics.Tests
{
    [TestFixture]
    public class PingObjectTests
    {
        public PingObject testPingObject;

        [SetUp]
        public void setUp()
        {
            testPingObject = new PingObject("8.8.8.8", 32, 3000);
        }
        [Test]
        public void DoAPingTest()
        {
            Assert.IsTrue(testPingObject.DoOnePing());
        }
        [TearDown]
        public void TearDown()
        {
            testPingObject = null;
        }
    }
}

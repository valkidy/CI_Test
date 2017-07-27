using System;
using NUnit.Framework;

namespace CI_Test_UnitTest
{
    [TestFixture]
    [Category("MyFirstTestRunning")]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(10, 10);
        }
    }
}

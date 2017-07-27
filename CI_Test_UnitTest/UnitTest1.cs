using System;
using NUnit.Framework;

namespace CI_Test_UnitTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(2, 10);
        }
    }
}

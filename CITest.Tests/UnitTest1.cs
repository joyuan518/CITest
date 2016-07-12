using System;
using NUnit.Framework;
using CITest.Function;

namespace CITest.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(new Test().Add(1, 2), 3);
        }
    }
}

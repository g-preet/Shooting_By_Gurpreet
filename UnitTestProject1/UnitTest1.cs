using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shooting_By_Gurpreet;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ShootClass obj = new ShootClass();

            obj.ShootgpLoop(4);
            Assert.IsTrue(true);
        }
    }
}

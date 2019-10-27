using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WormNamespace;
using IWormNamespace;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Worm worm = new Worm();
            Fruits.Apple myApple = new Fruits.Apple(worm);  // Dependency Injection
            Assert.AreEqual(myApple.IsRotten(), false);

        }
    }
}

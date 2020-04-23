using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectDog
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int i = 1;
            Assert.AreEqual(i, 1);
        }
    }
}

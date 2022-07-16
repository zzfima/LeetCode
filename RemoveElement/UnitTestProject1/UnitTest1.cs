using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoveElement;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] ints = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int[] resInts = { 0, 1, 4, 0, 3, 0, 4, 2 };
            int resInt = 5;

            var res = Solution.RemoveElement(ints, 2);
            Assert.AreEqual(resInt, res);
            CollectionAssert.AreEqual(resInts, ints);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] ints = { 3, 2, 2, 3 };
            int[] resInts = { 2, 2, 2, 3 };
            int resInt = 2;

            var res = Solution.RemoveElement(ints, 3);
            Assert.AreEqual(resInt, res);
            CollectionAssert.AreEqual(resInts, ints);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] ints = { 2 };
            int[] resInts = { 2 };
            int resInt = 1;

            var res = Solution.RemoveElement(ints, 3);
            Assert.AreEqual(resInt, res);
            CollectionAssert.AreEqual(resInts, ints);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] ints = { 1 };
            int[] resInts = { 1 };
            int resInt = 0;

            var res = Solution.RemoveElement(ints, 1);
            Assert.AreEqual(resInt, res);
            CollectionAssert.AreEqual(resInts, ints);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoveDuplicatesSortedArray;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] ints = { 1, 2, 3 };
            int[] resInts = { 1, 2, 3 };
            int resInt = 3;

            var res = Solution.RemoveDuplicates(ints);
            Assert.AreEqual(resInt, res);
            CollectionAssert.AreEqual(resInts, ints);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] ints = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int[] resInts = { 0, 1, 2, 3, 4, 2, 2, 3, 3, 4 };
            int resInt = 5;

            var res = Solution.RemoveDuplicates(ints);
            Assert.AreEqual(resInt, res);
            CollectionAssert.AreEqual(resInts, ints);
        }
    }
}
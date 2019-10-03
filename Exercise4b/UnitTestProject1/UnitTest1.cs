using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise4b;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4, 5 };
            bool result1 = Program.IsContain5(Arr1);
            Assert.AreEqual(true, result1);

            int[] Arr2 = new int[] { 1, 82, 3, 4, 6 };
            bool result2 = Program.IsContain5(Arr2);
            Assert.AreEqual(false, result2);

            int[] Arr3 = new int[0];
            bool result3 = Program.IsContain5(Arr3);
            Assert.AreEqual(false, result3);
        }
        [TestMethod]
        public void TestContain5or6()
        {
            int[] Arr1 = new int[] { 1, 5, 7, 8, 9 };
            bool result1 = Program.IsContain5or6(Arr1);
            Assert.AreEqual(true, result1);

            int[] Arr2 = new int[] { 1, 3, 7, 8, 9 };
            bool result2 = Program.IsContain5or6(Arr2);
            Assert.AreEqual(false, result2);

            int[] Arr3 = new int[] { 1, 2, 6, 7, 8, 9 };
            bool result3 = Program.IsContain5or6(Arr3);
            Assert.AreEqual(true, result3);
        }
        [TestMethod]
        public void TestContain5and6()
        {
            int[] Arr = new int[] { 1, 0, 7, 8, 9 };
            bool result1 = Program.IsContain5and6(Arr);
            Assert.AreEqual(false, result1);

            int[] Arr4 = new int[] { 1, 5, 7, 8, 9 };
            bool result4 = Program.IsContain5and6(Arr4);
            Assert.AreEqual(false, result4);

            int[] Arr2 = new int[] { 1, 6, 7, 8, 9 };
            bool result2 = Program.IsContain5and6(Arr2);
            Assert.AreEqual(false, result2);

            int[] Arr3 = new int[] { 1, 5, 6, 7, 8, 9 };
            bool result3 = Program.IsContain5and6(Arr3);
            Assert.AreEqual(true, result3);
        }
        [TestMethod]
        public void TestCount5()
        {
            int[] Arr1 = new int[] { 1, 0, 6, 4, 2 };
            int result1 = Program.Count5(Arr1);
            Assert.AreEqual(0, result1);

            int[] Arr2 = new int[] { 1, 0, 5, 6, 4, 2 };
            int result2 = Program.Count5(Arr2);
            Assert.AreEqual(1, result2);

            int[] Arr3 = new int[] { 1, 0, 5, 5, 6, 4, 2 };
            int result3 = Program.Count5(Arr3);
            Assert.AreEqual(2, result3);
        }
        [TestMethod]
        public void TestCount5or6()
        {
            int[] Arr1 = new int[] { 1, 0, 6, 4, 2 };
            int result1 = Program.Count5or6(Arr1);
            Assert.AreEqual(1, result1);

            int[] Arr2 = new int[] { 1, 0, 6, 6, 4, 2 };
            int result2 = Program.Count5or6(Arr2);
            Assert.AreEqual(2, result2);

            int[] Arr3 = new int[] { 1, 0, 5, 6, 4, 2 };
            int result3 = Program.Count5or6(Arr3);
            Assert.AreEqual(2, result3);
        }
        [TestMethod]
        public void TestSum()
        {
            int[] Arr1 = new int[] { 1, 2 };
            int result1 = Program.Sum(Arr1);
            Assert.AreEqual(3, result1);

            int[] Arr2 = new int[] { 2, 2, 2 };
            int result2 = Program.Sum(Arr2);
            Assert.AreEqual(6, result2);

            int[] Arr3 = new int[] { 0, 0, 0 };
            int result3 = Program.Sum(Arr3);
            Assert.AreEqual(0, result3);

        }
    }
}


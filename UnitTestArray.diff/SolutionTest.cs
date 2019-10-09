using System;
using Array.diff;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestArray.diff
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void SampleTest()
        {
            CollectionAssert.AreEqual(new int[] { 2 },        Kata.ArrayDiff(new int[] { 1, 2 },      new int[] { 1 }));
            CollectionAssert.AreEqual(new int[] { 2, 2 },     Kata.ArrayDiff(new int[] { 1, 2, 2 },   new int[] { 1 }));
            CollectionAssert.AreEqual(new int[] { 1 },        Kata.ArrayDiff(new int[] { 1, 2, 2 },   new int[] { 2 }));
            CollectionAssert.AreEqual(new int[] { 1, 2, 2 },  Kata.ArrayDiff(new int[] { 1, 2, 2 },   new int[] { }));
            CollectionAssert.AreEqual(new int[] { },          Kata.ArrayDiff(new int[] { },           new int[] { 1, 2 }));
        }
    }
}

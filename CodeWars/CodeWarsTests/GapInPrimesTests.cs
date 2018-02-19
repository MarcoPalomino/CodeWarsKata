using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    [TestClass()]
    public class GapInPrimesTests
    {
        [TestMethod()]
        public void DoGapTest()
        {
            var gap = 2;
            var initialNumber = 100;
            var finalNumber = 110;

            var gapInPrimes = new GapInPrimes();
            var result = gapInPrimes.DoGap(gap, initialNumber, finalNumber);

            Assert.IsTrue(new long[] { 101, 103 }.SequenceEqual(result), "Incorrect");
        }

        [TestMethod()]
        public void DoGapTestWithNull()
        {
            var gap = 6;
            var initialNumber = 100;
            var finalNumber = 110;

            var gapInPrimes = new GapInPrimes();
            var result = gapInPrimes.DoGap(gap, initialNumber, finalNumber);

            Assert.AreEqual(null, result, "Incorrect");
        }

        [TestMethod()]
        public void DoGapLongTest()
        {
            var gap = 8;
            var initialNumber = (long)3e6;
            var finalNumber = (long)4e6;
            
            var gapInPrimes = new GapInPrimes();
            var result = gapInPrimes.DoGap(gap, initialNumber, finalNumber);

            
            Assert.IsTrue(new long[] { 3000953 , 3000961 }.SequenceEqual(result), "Incorrect");
        }
    }
}
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

            Assert.AreEqual(new long[] { 101, 103 }, result, "Incorrect");
            
        }
    }
}
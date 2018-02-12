using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestClass()]
    public class SumMultiplesNumberTests
    {
        [TestMethod()]
        public void FindSumTest()
        {
            var number = 7;

            var sumMultiplesNumber = new SumMultiplesNumber();

            var result = sumMultiplesNumber.FindSum(number);

            Assert.AreEqual(14, result, "Incorrect");
        }

        [TestMethod()]
        public void FindSumTestForBigNumber()
        {
            var number = 10;

            var sumMultiplesNumber = new SumMultiplesNumber();

            var result = sumMultiplesNumber.FindSum(number);

            Assert.AreEqual(33, result, "Incorrect");
        }
    }
}
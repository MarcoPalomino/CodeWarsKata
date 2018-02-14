using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace CodeWarsTests
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
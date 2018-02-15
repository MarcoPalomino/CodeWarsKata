using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace CodeWarsTests
{
    [TestClass()]
    public class SubstractSumTests
    {
        [TestMethod()]
        public void SubstractTheSumTest()
        {
            var number = 1561964189;

            var substractSum = new SubstractSum();

            var result = substractSum.SubstractTheSum(number);

            Assert.AreEqual("apple", result, "Incorrect");
        }

        [TestMethod()]
        public void SubstractTheSumTestApple()
        {
            var number = 97;

            var substractSum = new SubstractSum();

            var result = substractSum.SubstractTheSum(number);

            Assert.AreEqual("apple", result, "Incorrect");
        }
    }

}
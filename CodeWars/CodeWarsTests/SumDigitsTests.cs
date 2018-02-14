using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace CodeWarsTests
{
    [TestClass()]
    public class SumDigitsTests
    {
        [TestMethod()]
        public void SumDigitsInNumberTest()
        {
            var number = 133;

            var sumDigits = new SumDigits();

            var result = sumDigits.SumDigitsInNumber(number);

            Assert.AreEqual(7, result, "Incorrect");
        }
    }
}
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
    public class CreditCardValidationTests
    {
        [TestMethod()]
        public void DovalidateTrueTest()
        {

            var number1 = "784 4210";
            var creditCard = new CreditCardValidation();
            var result1 = creditCard.Dovalidate(number1);
            Assert.AreEqual(true, result1);

            var number2 = "5088 5545 14786";
            var result2 = creditCard.Dovalidate(number2);
            Assert.AreEqual(true, result2);

        }

        [TestMethod()]
        public void DovalidateFalseTest()
        {
            var creditCard = new CreditCardValidation();
            var number = "170 560 4789";

            var result = creditCard.Dovalidate(number);

            Assert.AreEqual(false, result);

        }
        
    }
}
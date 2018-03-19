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
    public class CreatePhoneNumberTests
    {
        [TestMethod()]
        public void BuildPhoneNumberTest()
        {
            var numbers = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};

            var createPhoneNumber = new CreatePhoneNumber();
            var result = createPhoneNumber.BuildPhoneNumber(numbers);

            Assert.IsTrue(result.Equals("(123) 456-7890"), "Incorrect");
        }

        [TestMethod()]
        public void BuildSamePhoneNumberTest()
        {
            var numbers = new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            var createPhoneNumber = new CreatePhoneNumber();
            var result = createPhoneNumber.BuildPhoneNumber(numbers);

            Assert.IsTrue(result.Equals("(111) 111-1111"), "Incorrect");
        }
    }
}
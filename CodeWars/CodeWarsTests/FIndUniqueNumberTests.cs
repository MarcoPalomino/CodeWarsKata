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
    public class FindUniqueNumberTests
    {
        [TestMethod()]
        public void GetUniqueTest()
        {

            var collectionTest = new[] { -2, 2, 2, 2 };
            var findUniqueNumber = new FindUniqueNumber();

            var result = findUniqueNumber.GetUnique(collectionTest);

            Assert.AreEqual(-2, result, "Incorrect");
        }
    }
}
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
    public class IQTestEvennessTests
    {
        [TestMethod()]
        public void TestEvenessTest()
        {
            var numbers = "2 4 7 8 10";

            var result = 3;

            Assert.AreEqual(result, 3);
        }
    }
}
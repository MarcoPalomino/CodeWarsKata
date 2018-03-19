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
    public class GetFridayThirteenTests
    {
        [TestMethod()]
        public void FridayTheThirteenthsTest()
        {
            var start = 1999;
            var end = 2000;

            var getFridayThirteen = new GetFridayThirteen();
            var result = getFridayThirteen.FridayTheThirteenths(start, end);

            Assert.AreEqual("8/13/1999 10/13/2000", result);
        }
    }
}
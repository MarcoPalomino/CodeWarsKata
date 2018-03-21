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
    public class PaginationHelperTests
    {
        [TestMethod()]
        public void PaginationHelperItemCountTest()
        {
            var paginationHelper = new PaginationHelper<int>(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 }, 10);
            var pageItemCount = paginationHelper.ItemCount;
            Assert.AreEqual(pageItemCount, 24, "Incorrect");
        }


        [TestMethod()]
        public void PaginationHelperItemIndexTest()
        {
            var paginationHelper = new PaginationHelper<int>(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 }, 10);
            var pageIndex = paginationHelper.PageIndex(-1);
            Assert.AreEqual(pageIndex, -1, "Incorrect");

            pageIndex = paginationHelper.PageIndex(12);
            Assert.AreEqual(pageIndex, 1, "Incorrect");

            pageIndex = paginationHelper.PageIndex(24);
            Assert.AreEqual(pageIndex, -1, "Incorrect");
        }
        
    }
}
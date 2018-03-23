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
    public class FindUniqueStringTests
    {
        [TestMethod()]
        public void FindUniqueStringTest()
        {
            var collectionTest = new[] { "Aa", "aaa", "aaaaa", "BbBb", "Aaaa", "AaAaAa", "a" };
            var findUniqueString = new FindUniqueString();

            var result = findUniqueString.FindUnique(collectionTest);

            Assert.AreEqual("BbBb", result, "Incorrect");
        }
    }
}
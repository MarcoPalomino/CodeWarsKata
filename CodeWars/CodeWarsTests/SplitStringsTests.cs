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
    public class SplitStringsTests
    {
        [TestMethod()]
        public void DoSplitTest()
        {
            var word = "abc";
            
            var splitStrings = new SplitStrings();
            var result = splitStrings.DoSplit(word);

            Assert.IsTrue(new string[] { "ab", "c_" }.SequenceEqual(result), "Incorrect");
        }


        [TestMethod()]
        public void DoSplitTestOdd()
        {
            var word = "abcdef";

            var splitStrings = new SplitStrings();
            var result = splitStrings.DoSplit(word);

            Assert.IsTrue(new string[] { "ab", "cd", "ef" }.SequenceEqual(result), "Incorrect");
        }
    }
}
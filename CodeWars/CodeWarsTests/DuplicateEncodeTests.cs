using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestClass()]
    public class DuplicateEncodeTests
    {
        [TestMethod()]
        public void SimpleDuplicateEncoderTest()
        {
            var wordToEncode = "dic";
            var duplicateEncoder = new DuplicateEncode();

            var result = duplicateEncoder.DuplicateEncoder(wordToEncode);

            Assert.AreEqual("(((", result, "Incorrect");
        }

        [TestMethod()]
        public void LongDuplicateEncoderTest()
        {
            var wordToEncode = "recede";
            var duplicateEncoder = new DuplicateEncode();

            var result = duplicateEncoder.DuplicateEncoder(wordToEncode);

            Assert.AreEqual("()()()", result, "Incorrect");
        }

        [TestMethod()]
        public void DuplicateEncoderTestWithCase()
        {
            var wordToEncode = "Success";
            var duplicateEncoder = new DuplicateEncode();

            var result = duplicateEncoder.DuplicateEncoder(wordToEncode);

            Assert.AreEqual(")())())", result, "should ignore case");
        }
        
    }
}
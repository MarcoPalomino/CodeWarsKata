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
    public class JadenCaseTests
    {
        [TestMethod()]
        public void ToJadenCaseTest()
        {
            var originalSentence = "How can mirrors be reAl if our eYes aren't real";

            var jadenCase = new JadenCase();

            var results = jadenCase.ToJadenCase(originalSentence);

            Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real",results,"Strings didn't match.");
        }
    }
}
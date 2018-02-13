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
    public class HighestScoringWordTests
    {
        [TestMethod()]
        public void HighScoringTest()
        {
            var words = "man i need a taxi up to ubud";

            var highestScoringWord = new HighestScoringWord();
            var result = highestScoringWord.HighScoring(words);

            Assert.AreEqual("taxi", result, "Is incorrect");
        }

        [TestMethod()]
        public void HighScoringWithMultipleValuesTest()
        {
            var words = "what time are we climbing up to volcano";

            var highestScoringWord = new HighestScoringWord();
            var result = highestScoringWord.HighScoring(words);

            Assert.AreEqual("volcano", result, "Is incorrect");
        }


        [TestMethod()]
        public void HighScoringWithEmptyValuesTest()
        {
            var words = "";

            var highestScoringWord = new HighestScoringWord();
            var result = highestScoringWord.HighScoring(words);

            Assert.AreEqual("", result, "Is incorrect");
        }

        [TestMethod()]
        public void TestsWithLongWords()
        {
            var words = "uhptokvq evextjlhmj";

            var highestScoringWord = new HighestScoringWord();
            var result = highestScoringWord.HighScoring(words);

            Assert.AreEqual("uhptokvq", result, "Is incorrect");
        }

        [TestMethod()]
        public void TestsWithSameWords()
        {
            var words = "house the house for working";

            var highestScoringWord = new HighestScoringWord();
            var result = highestScoringWord.HighScoring(words);

            Assert.AreEqual("working", result, "Is incorrect");
        }
    }
}
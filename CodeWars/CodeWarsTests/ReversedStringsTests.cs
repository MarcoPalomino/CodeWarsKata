using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;


namespace CodeWarsTests
{
    [TestClass()]
    public class ReversedStringsTests
    {
        [TestMethod()]
        public void DoReverseTest()
        {
            var wordToRevert = "word";
            var reverseString = new ReversedStrings();

            var result = reverseString.DoReverse(wordToRevert);

            Assert.AreEqual("drow",result, "Incorrect");
        }

        [TestMethod()]
        public void DoReverseEmptyTest()
        {
            var wordToRevert = "";
            var reverseString = new ReversedStrings();

            var result = reverseString.DoReverse(wordToRevert);

            Assert.AreEqual("", result, "Incorrect");
        }

        [TestMethod()]
        public void DoReverseSentenceTest()
        {
            var wordToRevert = "The house is green";
            var reverseString = new ReversedStrings();

            var result = reverseString.DoReverse(wordToRevert);

            Assert.AreEqual("neerg si esuoh ehT", result, "Incorrect");
        }
    }
}
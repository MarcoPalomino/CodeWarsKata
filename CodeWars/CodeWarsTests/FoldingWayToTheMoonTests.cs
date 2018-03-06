using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;


namespace CodeWarsTests
{
    [TestClass()]
    public class FoldingWayToTheMoonTests
    {
        [TestMethod()]
        public void FoldToTest()
        {
            var distance = 384000000;
            var expected = 42;
            var foldWayToMoon = new FoldingWayToTheMoon();
            var results = foldWayToMoon.FoldTo(distance);
            
            Assert.AreEqual(expected, results);
        }

        [TestMethod()]
        public void FoldToTestLowValues()
        {
            var distance = 1.40996291920065E-10;
            var expected = 0;
            var foldWayToMoon = new FoldingWayToTheMoon();
            var results = foldWayToMoon.FoldTo(distance);

            Assert.AreEqual(expected, results);
        }
    }
}
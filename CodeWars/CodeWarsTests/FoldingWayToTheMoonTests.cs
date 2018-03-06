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
    }
}
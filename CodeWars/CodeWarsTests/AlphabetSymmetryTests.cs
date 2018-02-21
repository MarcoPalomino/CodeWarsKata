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
    public class AlphabetSymmetryTests
    {
        [TestMethod()]
        public void SolveSymmetryTest()
        {
            var words = new List<string> { "abode", "ABc", "xyzD" };
            var initialNumber = 100;
            var finalNumber = 110;

            var alphabetSymmetry = new AlphabetSymmetry();
            var result = alphabetSymmetry.SolveSymmetry(words);

            Assert.IsTrue(new List<int> { 4, 3, 1 }.SequenceEqual(result), "Incorrect");
        }
    }
}
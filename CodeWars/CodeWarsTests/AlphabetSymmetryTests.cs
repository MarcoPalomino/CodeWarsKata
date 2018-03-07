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

            var alphabetSymmetry = new AlphabetSymmetry();
            var result = alphabetSymmetry.SolveSymmetry(words);

            Assert.IsTrue(new List<int> { 4, 3, 1 }.SequenceEqual(result), "Incorrect");
        }

        [TestMethod()]
        public void SolveSymmetryTestNotValuesFound()
        {
            var words = new List<string> { "abide", "ABc", "xyz" };

            var alphabetSymmetry = new AlphabetSymmetry();
            var result = alphabetSymmetry.SolveSymmetry(words);

            Assert.IsTrue(new List<int> { 4, 3, 0 }.SequenceEqual(result), "Incorrect");
        }

        [TestMethod()]
        public void SolveSymmetryTestMultipleValuesFound()
        {
            var words = new List<string> { "IAMDEFANDJKL", "thedefgh", "xyzDEFghijabc" };

            var alphabetSymmetry = new AlphabetSymmetry();
            var result = alphabetSymmetry.SolveSymmetry(words);

            Assert.IsTrue(new List<int> { 6, 5, 7 }.SequenceEqual(result), "Incorrect");
        }


        
        
    }
}
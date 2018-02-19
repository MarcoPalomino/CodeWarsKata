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
    public class RagbabyCipherTests
    {
        [TestMethod()]
        public void EncodeTest()
        {
            var testSentence = "This is an example.";
            var key = "cipher";

            var ragbabyCipher = new RagbabyCipher();

            var results = ragbabyCipher.Encode(testSentence, key);
            
            Assert.AreEqual("Urew pu bq rzfsbtj.", results, "Incorrect");
        }

        [TestMethod()]
        public void DecodeTest()
        {
            var testSentence = "Urew pu.. bq rzfsbtj";
            var key = "cipher";

            var ragbabyCipher = new RagbabyCipher();

            var results = ragbabyCipher.Decode(testSentence, key);

            Assert.AreEqual("This is.. an example", results, "Incorrect");
        }

        [TestMethod()]
        public void MultipleEncodeDecodeTests()
        {
            var ragbabyCipher = new RagbabyCipher();

            //Assert.AreEqual("ihrbfj", ragbabyCipher.Encode("cipher", "cipher"));
            //Assert.AreEqual("ihrbfj", ragbabyCipher.Encode("cipher", "cccciiiiippphheeeeerrrrr"));
            //Assert.AreEqual("Urew pu bq rzfsbtj.", ragbabyCipher.Encode("This is an example.", "cipher"));
            //Assert.AreEqual("Urew.uRew.urEw.ureW...", ragbabyCipher.Encode("This.tHis.thIs.thiS...", "cipher"));

            //Assert.AreEqual("cipher", ragbabyCipher.Decode("ihrbfj", "cipher"));
            //Assert.AreEqual("This is an example.", ragbabyCipher.Decode("Urew pu bq rzfsbtj.", "cipher"));
            //Assert.AreEqual("This.tHis.thIs.thiS...", ragbabyCipher.Decode("Urew.uRew.urEw.ureW...", "cipher"));

            Assert.AreEqual("This is an example.", ragbabyCipher.Encode(ragbabyCipher.Decode("This is an example.", "cipher"), "cipher"));
            //Assert.AreEqual("This is an example.", ragbabyCipher.Decode(ragbabyCipher.Encode("This is an example.", "cipher"), "cipher"));
        }
    }
}
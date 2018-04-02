using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class SplitStrings
    {
        public string[] DoSplit(string word)
        {
            var isOdd = word.Length % 2 == 1;
            var splitStrings = new List<string>();

            if (isOdd)
            {
                var lastLetter = word[word.Length - 1];
                word = word.Remove(word.Length - 1, 1);
                for (int i = 0; i <= word.Length - 2; i += 2)
                    splitStrings.Add(word[i].ToString() + word[i + 1]);
                
                splitStrings.Add(lastLetter + "_");
            }
            else
            {
                for (int i = 0; i <= word.Length - 2; i += 2)
                    splitStrings.Add(word[i].ToString() + word[i + 1]);
            }
            return splitStrings.ToArray();
        }
    }
}

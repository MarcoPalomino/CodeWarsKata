using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public class HighestScoringWord
    {
        /*
        Given a string of words, you need to find the highest scoring word.

        Each letter of a word scores points according to it's position in the alphabet: a = 1, b = 2, c = 3 etc.

        You need to return the highest scoring word as a string.

        If two words score the same, return the word that appears earliest in the original string.

        All letters will be lowercase and all inputs will be valid. 
        */
        public string HighScoring(string words)
        {
            var separator = ' ';
            var wordsToEvaluate = words.Split(separator).ToList();
            var wordsWithAsciiSum = new Dictionary<string, int>();

            wordsToEvaluate.ForEach(item =>
            {
                if(!wordsWithAsciiSum.ContainsKey(item))
                    wordsWithAsciiSum.Add(item,Encoding.ASCII.GetBytes(item).Select(value => (int) value).Sum() - 96 * item.Length);
            });
            
            return wordsWithAsciiSum.OrderByDescending(item=>item.Value).FirstOrDefault().Key;
        }
    }
}

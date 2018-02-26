using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class AlphabetSymmetry
    {
        public List<int> SolveSymmetry(List<string> words)
        {
            var alphabet = new string(Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (char)i).ToArray());
            var lettersOnPositions = new List<int>();
            
            words.ForEach(word =>
            {
                var countLetterInPositions = 0;
                word.ToLower().ToList().ForEach(letter =>
                {
                    var indexLetterInAlphabet = alphabet.IndexOf(letter);
                    var indexLetterInWord = word.ToLower().IndexOf(letter);
                    if (indexLetterInAlphabet == indexLetterInWord) countLetterInPositions++;
                });
                lettersOnPositions.Add(countLetterInPositions);
            });
            return lettersOnPositions;
        }
    }
}

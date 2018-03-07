using System.Collections.Generic;
using System.Linq;


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
                for (int i = 0; i< word.ToLower().Length; i++) 
                    if (alphabet[i] == word.ToLower()[i]) countLetterInPositions++;

                lettersOnPositions.Add(countLetterInPositions);
            });
            
            return lettersOnPositions;
        }
    }
}

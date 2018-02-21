using System.Linq;

namespace CodeWars
{
    public class RagbabyCipher
    {
        /*
         Introduction
         The ragbaby cipher is a substitution cipher that encodes/decodes a text using a keyed alphabet and their position in the plaintext word they are a part of.
         
         To encrypt the text This is an example. with the key cipher, first construct a keyed alphabet:
         
         c    i    p    h    e    r    a    b    d    f    g    j    k    l    m    n    o    q    s    t    u    v    w    x    y    z
         Then, number the letters in the text as follows:
         
         T    h    i    s         i    s         a    n         e    x    a    m    p    l    e    .
         1    2    3    4         1    2         1    2         1    2    3    4    5    6    7
         To obtain the encoded text, replace each character of the word with the letter in the keyed alphabet the corresponding number of places to the right of it (wrapping if necessary). Non-alphabetic characters are preserved to mark word boundaries.
         
         Our ciphertext is then Urew pu bq rzfsbtj.
         
         Task
         Wirate functions encode and decode which accept 2 parameters:
         
         text - string - a text to encode/decode
         key - string - a key
         
         Notes
         handle lower and upper case in text string
         key consists of only lowercase characters
        */

        public string Encode(string text, string key)
        {
            var coder = GetCoder(key);
            var newText = string.Empty;
            var countSpaces = 1;

            text.ToList().ForEach(letter =>
            {
                switch (letter)
                {
                    case ' ':
                        countSpaces = 1;
                        newText += ' ';
                        break;
                    default:
                        if (coder.IndexOf(letter.ToString().ToLower()) == -1)
                        {
                            newText += letter;
                            countSpaces = 1;
                            break;
                        }
                        var indexSelected = coder.IndexOf(letter.ToString().ToLower());
                        var newLetter = indexSelected + countSpaces > coder.Length - 1 
                                    ? coder[indexSelected + countSpaces - coder.Length].ToString()
                                    : coder[indexSelected + countSpaces].ToString();

                        newText += char.IsUpper(letter) ? newLetter.ToUpper() : newLetter;
                        countSpaces++;
                        break;
                }
            });

            return newText;
        }

        public string Decode(string text, string key)
        {
            var coder = GetCoder(key);
            var newText = string.Empty;
            var countSpaces = 1;

            text.ToList().ForEach(letter =>
            {
                switch (letter)
                {
                    case ' ':
                        countSpaces = 1;
                        newText += ' ';
                        break;
                    default:
                        if (coder.IndexOf(letter.ToString().ToLower()) == -1)
                        {
                            newText += letter;
                            countSpaces = 1;
                            break;
                        }
                        var indexSelected = coder.IndexOf(letter.ToString().ToLower());
                        var newLetter = indexSelected - countSpaces < 0
                            ? coder[coder.Length - countSpaces + indexSelected].ToString()//letter.ToString()
                            : coder[indexSelected - countSpaces].ToString();


                        newText += char.IsUpper(letter) ? newLetter.ToString().ToUpper() : newLetter.ToString();
                        countSpaces++;
                        break;
                }
            });

            return newText;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private string GetCoder(string key)
        {
            var alphabet = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (char)i).ToArray();
            var alphabetWithoutKey = new string(alphabet);
            key.Distinct().ToList().ForEach(letter => alphabetWithoutKey = alphabetWithoutKey.Replace(letter.ToString(), string.Empty));
            return new string(key.Distinct().ToArray()) + alphabetWithoutKey;
        }
    }
}

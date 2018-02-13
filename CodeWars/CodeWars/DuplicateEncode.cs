using System.Linq;


namespace CodeWars
{
    public class DuplicateEncode
    {
        /*
         The goal of this exercise is to convert a string to a new string where each character in the new string is '(' if that character appears only once in the original string, or ')' if that character appears more than once in the original string. Ignore capitalization when determining if a character is a duplicate.

        Examples:

        "din" => "((("

        "recede" => "()()()"

        "Success" => ")())())"

        "(( @" => "))(("
             
        */
        public string DuplicateEncoder(string wordToEncode)
        {
            var newWordEncode = string.Empty;
            wordToEncode.ToCharArray().ToList().ForEach(letter=>
            {
                newWordEncode = newWordEncode + (wordToEncode.AsEnumerable()
                                                             .Count(item => item.ToString().ToLower() == letter.ToString().ToLower()) > 1
                                                             ? ")" : "(");
            });

            return newWordEncode;
        }
    }
}

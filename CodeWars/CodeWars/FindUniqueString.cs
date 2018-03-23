using System.Linq;


namespace CodeWars
{
    public class FindUniqueString
    {
        /*
        
        There is an array of strings. All strings contains similar letters except one. Try to find it!

        findUniq([ 'Aa', 'aaa', 'aaaaa', 'BbBb', 'Aaaa', 'AaAaAa', 'a' ]) === 'BbBb'
        findUniq([ 'abc', 'acb', 'bac', 'foo', 'bca', 'cab', 'cba' ]) === 'foo'
        Strings may contain spaces. Spaces is not significant, only non-spaces symbols matters. E.g. string that contains only spaces is like empty string.

        It’s guaranteed that array contains more than 3 strings.
 
        */

        public string FindUnique(string[] words)
        {
            var grouped = words.Select(item => item.ToLower()).GroupBy(item => item);
            var letter = grouped.Select(i => i.Key.ToArray()[0]);
            var differentLetter = letter.GroupBy(item => item).FirstOrDefault(i => i.Count() == 1).Key;

            return words.ToList().FirstOrDefault(item=>item.ToLower().Contains(differentLetter.ToString()));
        }

    }
}

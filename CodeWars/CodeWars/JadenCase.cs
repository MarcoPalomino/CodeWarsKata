using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class JadenCase
    {
        /*
        Jaden Smith, the son of Will Smith, is the star of films such as The Karate Kid (2010) and After Earth (2013). 
        Jaden is also known for some of his philosophy that he delivers via Twitter. When writing on Twitter, he is known for almost always capitalizing every word.
        
        Your task is to convert strings to how they would be written by Jaden Smith. 
        The strings are actual quotes from Jaden Smith, but they are not capitalized in the same way he originally typed them. 

        Example:
        Not Jaden-Cased: "How can mirrors be real if our eyes aren't real"
        Jaden-Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"
        */

        public string ToJadenCase(string phrase)
        {
            var finalSentence = string.Empty;
            phrase.Split(' ').ToList().ForEach(word =>
            {
                var remainingWord = word.ToLowerInvariant().Remove(0, 1);
                finalSentence = finalSentence + " " + word.ToCharArray(0, word.Length).FirstOrDefault().ToString().ToUpperInvariant() + remainingWord;
            });

            return finalSentence.Trim();
        }
    }
}

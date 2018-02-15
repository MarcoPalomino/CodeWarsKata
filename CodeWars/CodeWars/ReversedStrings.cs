using System;
using System.Linq;

namespace CodeWars
{
    public class ReversedStrings
    {
        public string DoReverse(string str)
        {
            var newString = "";
            str.Reverse().ToList().ForEach(letter => newString += letter);
            return newString;
        }
    }
}
using System;
using System.Linq;

namespace CodeWars
{
    public class IQTestEvenness
    {
        public int TestEveness(string numbers)
        {
            var numbersToEvaluate = numbers.Split(' ').ToList();
            var evenNumbers = numbersToEvaluate.Count(number => (int.Parse(number)) % 2 == 0) == 1;
            
            var indexNumber = numbersToEvaluate.IndexOf(evenNumbers 
                ? numbersToEvaluate.FirstOrDefault(number => (int.Parse(number)) % 2 == 0) 
                : numbersToEvaluate.FirstOrDefault(number => (int.Parse(number)) % 2 != 0));

            return indexNumber + 1;
        }
    }
}

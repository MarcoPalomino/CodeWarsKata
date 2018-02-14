using System;
using System.Linq;

namespace CodeWars
{
    public class IQTestEvenness
    {
        public int TestEveness(string numbers)
        {
            var numbersToEvaluate = numbers.Split(' ').ToList();
            int indexNumber;
            var evenNumbers = numbersToEvaluate.Count(number => (Int32.Parse(number)) % 2 == 0);

            indexNumber = numbersToEvaluate.IndexOf(evenNumbers == 1 
                                                    ? numbersToEvaluate.FirstOrDefault(number => (Int32.Parse(number)) % 2 == 0) 
                                                    : numbersToEvaluate.FirstOrDefault(number => (Int32.Parse(number)) % 2 != 0));

            return indexNumber;
        }
    }
}

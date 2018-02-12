using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class SumMultiplesNumber
    {
        /*
         Your task is to write function findSum.
         Upto and including n, this function will return the sum of all multiples of 3 and 5.
         For example:
         FindSum(5) should return 8 (3 + 5)
         FindSum(10) should return 33 (3 + 5 + 6 + 9 + 10)    
        */
        public int FindSum(int number)
        {
            var multiplesToValidate = new List<int> { 3, 5 };
            if (number < 0)
                throw new Exception("Please, enter positive numbers");

            var multiplesSelected = from num in Enumerable.Range(1, number)
                where multiplesToValidate.Any(item => num % item == 0)
                select num;

            return multiplesSelected.Sum();
        }
    }
}

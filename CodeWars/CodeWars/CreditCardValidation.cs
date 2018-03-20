using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class CreditCardValidation
    {

        /*
            In this Kata, you will implement the Luhn Algorithm, which is used to help validate credit card numbers.

            Given a positive integer of up to 16 digits, return true if it is a valid credit card number, and false if it is not.

            Here is the algorithm:

            Double every other digit, scanning from right to left, starting from the second digit (from the right).

            Another way to think about it is: if there are an even number of digits, double every other digit starting with the first; if there are an odd number of digits, double every other digit starting with the second:

            1714 ==> [1*, 7, 1*, 4] ==> [2, 7, 2, 4]

            12345 ==> [1, 2*, 3, 4*, 5] ==> [1, 4, 3, 8, 5]

            891 ==> [8, 9*, 1] ==> [8, 18, 1]
            If a resulting number is greater than 9, replace it with the sum of its own digits (which is the same as subtracting 9 from it):
            
            [8, 18*, 1] ==> [8, (1+8), 1] ==> [8, 9, 1]

            or:

            [8, 18*, 1] ==> [8, (18-9), 1] ==> [8, 9, 1]
            Sum all of the final digits:

            [8, 9, 1] ==> 8 + 9 + 1 = 18
            Finally, take that sum and divide it by 10. If the remainder equals zero, the original credit card number is valid.

            18 (modulus) 10 ==> 8 , which is not equal to 0, so this is not a valid credit card number
        
       */


        public bool Dovalidate(string numbers)
        {
            var numbersWithFormat = numbers.Replace(" ", "");
            var startIndex = numbersWithFormat.Length % 2 == 0 ? 0: 1;

            for (int i = startIndex; i <= numbersWithFormat.Length - 2; i+=2)
            {
                var numberSelected = (int)Char.GetNumericValue(numbersWithFormat[i]);
                var newNumber = numberSelected * 2 > 9 ? SumDigits(numberSelected * 2) : numberSelected * 2;

                numbersWithFormat = numbersWithFormat.Remove(i, 1);
                numbersWithFormat = numbersWithFormat.Insert(i, newNumber.ToString());
            }

            var finalSum = 0;
            for (int i = 0; i < numbersWithFormat.Length; i++)
                finalSum += (int)Char.GetNumericValue(numbersWithFormat[i]);

            return finalSum % 10 == 0;
        }

        private int SumDigits(int number)
        {
            var isNegative = number < 0;
            var digitsInNumber = new List<int>();
            var absoluteValue = isNegative ? number * -1 : number;

            while (absoluteValue != 0)
            {
                var integerPart = absoluteValue / (int)Math.Pow(10, absoluteValue.ToString().Length - 1);
                absoluteValue = absoluteValue - integerPart * (int)Math.Pow(10, absoluteValue.ToString().Length - 1);

                int elementToAdd;
                if (integerPart > 0)
                    elementToAdd = integerPart;
                else
                {
                    elementToAdd = absoluteValue;
                    absoluteValue = 0;
                }

                digitsInNumber.Add(elementToAdd);
            }

            return digitsInNumber.AsEnumerable().Sum();
        }
    }
}

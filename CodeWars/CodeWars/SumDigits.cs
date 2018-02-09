using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class SumDigits
    {
        public int SumDigitsInNumber(int number)
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

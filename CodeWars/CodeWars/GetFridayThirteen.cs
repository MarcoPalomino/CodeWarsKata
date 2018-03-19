using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class GetFridayThirteen
    {
        /*
          Create the function fridayTheThirteenths that accepts a start year and an end year (inclusive), and returns all of the dates where the 13th of a month lands on a Friday in the given range of year(s).

          The return value should be a string where each date is seperated by a space. The date should be formatted like 9/13/2014 where months do not have leading zeroes and are separated with forward slashes.

          If no end year is given, only return friday the thirteenths during the start year.

          Examples
          Kata.FridayTheThirteenths(1999, 2000)
          # returns "8/13/1999 10/13/2000"

          Kata.FridayTheThirteenths(2014, 2015)
          # returns "6/13/2014 2/13/2015 3/13/2015 11/13/2015"

          Kata.FridayTheThirteenths(2000)
          # returns "10/13/2000"

        */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public string FridayTheThirteenths(int start, int end = int.MinValue)
        {
            var startDate = new DateTime(start, 1, 1);
            var endDate = end == int.MinValue ? new DateTime(start, 12, 31) : new DateTime(end, 12, 31);
            var fridaysBetween = new List<DateTime>();

            for (var day = startDate.Date; day.Date <= endDate.Date; day = day.AddDays(1))
            {
                if(  day.DayOfWeek == DayOfWeek.Friday && day.Day == 13)
                    fridaysBetween.Add(day);
            }

            var finalFridays = string.Join(" ", fridaysBetween.ToArray());
            
            return finalFridays;
        }
    }
}

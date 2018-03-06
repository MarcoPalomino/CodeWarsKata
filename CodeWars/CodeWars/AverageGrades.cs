using System.Linq;


namespace CodeWars
{
    public class AverageGrades
    {
        /*
         
         There was a test in your class and you passed it. Congratulations!
         But you're an ambitious person. You want to know if you're better than the average student in your class.
         You got an array with your colleges' points. Now calculate the average to your points!

         Return True if you're better, else False!

         Note:
         Your points are not included in the array of your classes points. For calculating the average point you may add your point to the given array!
        
        */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="classPoints"></param>
        /// <param name="yourPoints"></param>
        /// <returns></returns>
        public bool BetterThanAverage(int[] classPoints, int yourPoints)
        {
            return yourPoints > (classPoints.Sum() + yourPoints) / (classPoints.Length + 1);
        }

    }
}

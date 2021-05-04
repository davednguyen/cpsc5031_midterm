using System;

namespace PythagoreanTheorem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Midterm");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Test case 1 (2 dimensions): p1[3, 8], p2[8, 3]");
            int[] p1 = new int[] { 3, 8 };
            int[] p2 = new int[] { 8, 4 };
            var distanceA = Distance(p1, p2, 2);
            Console.WriteLine(distanceA);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("test case 2 (3 dimensions): p1[-8, 8, -8], p2[-3, 2, 10]");
            int[] pA = new int[] { -8, 8, -8 };
            int[] pB = new int[] { -3, 2, 10 };
            var distanceB = Distance(pA, pB, 3);
            Console.WriteLine(distanceB);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("test case 3 (0 dimensions and empty array): p1[], p2[]");
            int[] p1A = new int[] {};
            int[] p1B = new int[] {};
            var distanceC = Distance(p1A, p1B, 0);
            Console.WriteLine(distanceC);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("test case 4 (null arrays): p1[], p2[]");
            int[] p2A = null;
            int[] p2B = null;
            var distanceD = Distance(p2A, p2B, 2);
            Console.WriteLine(distanceD);

            Console.WriteLine("-------------------Pythagorean Theorem recursive----------------------");
            Console.WriteLine("Midterm");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Test case 5 (2 dimensions): p1[3, 8], p2[8, 3]");
              var distanceAR = DistanceRecursive(p1, p2, 1, 0);
            Console.WriteLine(distanceAR);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("test case 6 (3 dimensions): p1[-8, 8, -8], p2[-3, 2, 10]");
            var distanceBR = DistanceRecursive(pA, pB, 2, 0);
            Console.WriteLine(distanceBR);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("test case 7 (0 dimensions and empty array): p1[], p2[]");
            var distanceCR = DistanceRecursive(p1A, p1B, 0, 0);
            Console.WriteLine(distanceCR);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("test case 8 (null arrays): p1[], p2[]");
            var distanceDR = DistanceRecursive(p2A, p2B, 2, 0);
            Console.WriteLine(distanceDR);
        }


        /// <summary>
        /// Get a distance between points based on Pythagorean Theorem
        /// </summary>
        /// <param name="p1">array for x1, y1, or n demension</param>
        /// <param name="p2">array for x2, y2, or n demension</param>
        /// <param name="numDimensions">number of demension</param>
        /// <returns>distance between points</returns>
        public static float Distance(int[] p1, int[] p2, int numDimensions)
        {
            if(p1 == null && p2 == null || p1.Length == 0 && p2.Length == 0)
            {
                return 0;
            }
            else if(p1 != null && p2 != null)
            {
                float sum = 0;
                for (int i = 0; i < numDimensions; i++)
                {
                    sum = sum + ((p2[i] - p1[i]) * (p2[i] - p1[i]));
                }
                return (float)Math.Sqrt(sum);
            }
            else
            {
                return 0;
            }           
        }


        /// <summary>
        ///  Get a distance between points based on Pythagorean Theorem
        /// </summary>
        /// <param name="p1">array for x1, y1, or n demension</param>
        /// <param name="p2">array for x2, y2, or n demension</param>
        /// <param name="index">starting index of array</param>
        /// <param name="value">distance between points</param>
        /// <returns></returns>
        public static float DistanceRecursive(int[] p1, int[] p2, int index, float value)
        {
            if (p1 == null && p2 == null || p1.Length == 0 && p2.Length == 0)
            {
                return 0;
            }
            else if (index == 0)
            {
                float z = (p2[index] - p1[index]) * (p2[index] - p1[index]);
                return (float)Math.Sqrt(z + value);
            }
            else
            {
                float point = (p2[index] - p1[index]) * (p2[index] - p1[index]) + value;
                index--;
                return DistanceRecursive(p1, p2, index, point);
            }  
              
        }
    }
}

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

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="numDimensions"></param>
        /// <returns></returns>
        public static float Distance(int[] p1, int[] p2, int numDimensions)
        {
            if(p1 != null && p2 != null)
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
    }
}

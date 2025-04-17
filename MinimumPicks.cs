using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new();

            //MINIMUM PICKS
            Console.WriteLine("MINIMUM PICKS : " + p.SmallerAndGreaterElement(new List<int>() { 1, 4, 3 }));
        }

        /*----------------------------------------------------------------------------------------------
        | MINIMUM PICKS
        | You are given an array of integers A of size N.
        | Return the difference between the maximum among all even numbers of A and the minimum among all odd numbers in A.
        -----------------------------------------------------------------------------------------------*/
        public int MinimumPicks(List<int> A)
        {
            if (A.Count <= 1 || A.Count >= 1000000)
                return 0;

            int evenMax = int.MinValue;
            int oddMin = int.MaxValue;

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] % 2 == 0)
                {
                    if (A[i] > evenMax)
                        evenMax = A[i];
                }
                else
                {
                    if (A[i] < oddMin)
                        oddMin = A[i];
                }
            }
            return evenMax - oddMin;
        }
    }
}

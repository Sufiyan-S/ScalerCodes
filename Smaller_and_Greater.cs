
















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

            //Print Smaller and Greater Element
            Console.WriteLine("Smaller ang Greater Element : " + p.SmallerAndGreaterElement(new List<int>() { 1, 4, 3 }));
        }

        /*----------------------------------------------------------------------------------------------
        | Smaller and Greater
        | You are given an Array A of size N
        | Find for how many elements, there is a strictly smaller element and a strictly greater element.
        -----------------------------------------------------------------------------------------------*/
        public int SmallerAndGreaterElement(List<int> A)
        {
            int count = 0;
            if (A.Count <= 1 || A.Count > 100000)
                return count;

            count = A.Count - 2;
            A.Sort();

            int i = 1;
            while (i < A.Count && A[0] == A[i])
            {
                count--;
                i++;
            }

            i = A.Count - 2;
            while (i > 1 && A[A.Count - 1] == A[i])
            {
                count--;
                i--;
            }

            if (count > 0)
                return count;
            else
                return 0;
        }
    }
}

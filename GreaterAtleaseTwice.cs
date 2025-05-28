







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

            //Elements which have at-least two greater elements/
            p.FindElementGreaterAtleaseTwice(new List<int>() { 1, 2, 3, 4, 5 });
        }

        /*----------------------------------------------------------------------------------------------
        | Elements which have at-least two greater elements
        | You are given an array of distinct integers A, you have to find and return all elements in array 
        | which have at-least two greater elements than themselves.
        | NOTE: The result should have the order in which they are present in the original array.
        -----------------------------------------------------------------------------------------------*/
        public List<int> FindElementGreat
            erAtleaseTwice(List<int> A)
        {

            if (A.Count <= 2 || A.Count > 100000)
                return new List<int>();

            int first = int.MinValue;
            int second = int.MinValue;

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] > first)
                {
                    second = first;
                    first = A[i];
                }
                else if (A[i] > second)
                    second = A[i];
            }

            A.Remove(first);
            A.Remove(second);

            return A;
        }
    }
}

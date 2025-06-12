








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
            
            //Print Smaller and Greer Element
            Console.WriteLine("Smaller ang Greater Element : " + p.SmallerAndGreaterElement(new List<int>() { 1, 4, 3 }));

            //Elements which have at-least two greater elements/
            p.FindElementGreaterAtleaseTwice(new List<int>() { 1, 2, 3, 4, 5 });

            //MINIMUM PICKS
            Console.WriteLine("MINIMUM PICKS : " + p.SmallerAndGreaterElement(new List<int>() { 1, 4, 3 }));

            //Pattern Print 1
            p.PatternPrint1(4);
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

        /*----------------------------------------------------------------------------------------------
        | Elements which have at-least two greater elements
        | You are given an array of distinct integers A, you have to find and return all elements in array 
        | which have at-least two greater elements than themselves.
        | NOTE: The result should have the order in which they are present in the original array.
        -----------------------------------------------------------------------------------------------*/
        public List<int> FindElementGreaterAtleaseTwice(List<int> A)
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

        /*----------------------------------------------------------------------------------------------
        | Pattern Printing -1
        | Print a Pattern According to The Given Value of A.
        -----------------------------------------------------------------------------------------------*/
        public List<List<int>> PatternPrint1(int A)
        {
            if (A < 1 || A > 1000)
                return new List<List<int>>();

            List<List<int>> items = new List<List<int>>();
            List<int> item;
            for (int i = 1; i <= A; i++)
            {
                item = new List<int>();
                for (int j = 1; j <= i; j++)
                    item.Add(j);
                items.Add(item);
            }

            return items;
        }
    }
}

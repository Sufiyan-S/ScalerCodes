







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

            //Pattern Print 1
            p.PatternPrint1(4);
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

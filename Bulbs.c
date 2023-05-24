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
  

            //This problem is to find out minimun switch required to turn on all the bulbs
            p.Bulbd(new List<int>() { 1, 2, 3, 4, 5 });
        }
        
        public int bulbs(List<int> A)
        {
          int count = 0;
          bool zero = true;

          for (int i = 0; i < A.Count; i++)
          {
            if (zero)
            {
                if (A[i] == 0)
                {
                    count++;
                    zero = false;
                }
            } else if (A[i] == 1)
            {
                zero = true;
                count++;
            }
          }
            
          return count;
      }
    }
}

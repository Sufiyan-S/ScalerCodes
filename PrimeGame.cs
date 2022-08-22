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

            //This is just normal Game problem where both player are playing opimally
            p.solve(64, 96);
        }
        
        public int solve(int A, int B) 
        {
        if(B==1)
            return 2;
        if((A&1)==1)
            return 2;
        else
            return 1;
        }
    }
}

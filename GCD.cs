using System;








namespace TestProject
{
    class Solution
    {
      //Find find Commonn GCD factor among A and B
        public int gcd(int A, int B) {
            if (B == 0)
                return A;
        return gcd(B, A % B);
    }
}

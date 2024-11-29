

class Solution {
    public string solve(string A) {
        long a = long.Parse(A);
            int x = 1;
            long res = 0;
            for (int i = 62; i >= 2; i--)
            {
                if ((x << i) < a)
                {
                    res = computeGoodBase(a, i);
                    if (res != -1)
                        return res.ToString();
                }
            }
            return (a - 1).ToString();
        }
    public long computeGoodBase(long a, long bits)
        {
            long ans = (long)Math.Pow(a - 1, 1.0 / bits);

            long sum = 1;
            long currSum = 1;
            for (long i = 1; i <= bits; i++)
            {
                currSum *= ans;
                sum += currSum;
            }
            if (sum == a)
                return ans;
            return -1;
        }
}

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
}

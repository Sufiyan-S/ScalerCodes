



















class Solution {
    public int DeleteOne(List<int> A) {
        int n = A.Count;
        int []Prefix = new int[n + 2];
        int []Suffix = new int[n + 2] ;
        
        Prefix[1] = A[0];
        for (int i = 2; i <= n; i += 1)
        {
            Prefix[i] = gcd(Prefix[i - 1], A[i - 1]);
        }
    
        Suffix[n] = A[n - 1];
    
        for (int i = n - 1; i >= 1; i -= 1)
        {
            Suffix[i] = gcd(Suffix[i + 1], A[i - 1]);
        }
        
        int ans = Math.Max(Suffix[2], Prefix[n - 1]);
    
        for (int i = 2; i < n; i += 1)
        {
            ans = Math.Max(ans, gcd(Prefix[i - 1], Suffix[i + 1]));
        }
    
        return ans;
    }
    public int gcd(int A, int B) {
        if (B == 0)
          return A;
       return gcd(B, A % B);
    }
}

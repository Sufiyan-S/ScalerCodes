












class Solution {
    public int solve(List<int> A, int B) {
        int mod = 1000000007;
        
        int count = 0;
        int[] freq = new int[B];
        for(int  i = 0; i < A.Count; i++)
        {
           freq[A[i] % B]++;
        }

        count = (freq[0] % mod * (freq[0] - 1) % mod) / 2;
        for(int  i = 1 ; i <= B/ 2 && i != (B - i); i++){
            count= count % mod + (freq[i] % mod * freq[B-i] % mod) % mod;
        }

        if(B % 2 == 0)
            count= count % mod + (freq[B/2] % mod * (freq[B/2] - 1) % mod) / 2;

        return count % mod;
    }
}


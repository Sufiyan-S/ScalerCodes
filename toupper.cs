















class Solution {
    public List<char> to_upper(List<char> A) {
        for(int i=0;i<A.Count;i++)
        {
            if (A[i] >= 'a' && A[i] <= 'z')
                A[i] = (char)(A[i] - 32);
        }     
        return A;
    }
}


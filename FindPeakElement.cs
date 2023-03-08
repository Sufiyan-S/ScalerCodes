class Solution {
    public int solve(List<int> A) {
        if(A.Count == 0)
            return 0;
        if(A.Count == 1)
            return A[0];
        
        for(int i = 0; i < A.Count; i ++)
        {
            if(i == 0 )
            {
                if(A[0] >= A[1])
                    return A[0];
            }
            else if(i == A.Count - 1)
            {
                if(A[A.Count -1] >= A[A.Count -2])
                    return A[A.Count -1];
            }
            else
            {
                if(A[i] >= A[i-1] && A[i] >= A[i +1])
                    return A[i];
            }
        }
        return 0;
    }
}

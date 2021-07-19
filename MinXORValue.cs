class Solution {
    public int findMinXor(List<int> A) {
        A.Sort();
        int x=0;
        int min =int.MaxValue;
        for(int i=0;i<A.Count-1;i++)
        {
            x= A[i]^A[i+1];
            if(x < min)
                min =x;
        }
        return min;
    }
}

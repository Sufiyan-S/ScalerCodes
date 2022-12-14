class Solution {  
    
   
    
    
    public List<int> solve(List<int> A) {
        List<int> divsor= new List<int>();
        
        for(int i=0;i<A.Count;i++)
        {
            int cnt = 0;
            for(int j=1;j<=Math.Sqrt(A[i]);j++)
            {
                if(A[i] % j == 0)
                {
                 if (A[i] / j == j)
                    cnt++;
                else
                    cnt = cnt + 2;   
                }
            }
            divsor.Add(cnt);
        }
        
        return divsor;
    }
}


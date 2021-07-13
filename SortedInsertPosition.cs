class Solution {
    public int searchInsert(List<int> A, int B) {
        int start  = 0, end = A.Count -1, mid;
        
        while(start <= end){
            mid = (end - start)/2 + start;

            if(A[mid] == B) 
                return mid;
            else if(mid < B)
                start = mid + 1;
            else
                end = mid - 1;
        }
        return end + 1;
    }
}


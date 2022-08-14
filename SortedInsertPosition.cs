/*

Sorted Insert Position
Problem Description

Given a sorted array A of size N and a target value B, return the index (0-based indexing) if the target is found.
If not, return the index where it would be if it were inserted in order.

Input Format
First argument is an integer array A of size N.
Second argument is an integer B.

Example Input
Input 1:
A = [1, 3, 5, 6]
B = 5
Input 2:
A = [1]
B = 1

Example Output
Output 1:
2
Output 2:
0
*/
class Solution {
    public int searchInsert(List<int> A, int B) {
        int start  = 0, end = A.Count -1, mid;
        
        while(start <= end){
            mid = (end - start)/2 + start;

            if(A[mid] == B) 
                return mid;
            else if(A[mid] < B)
                start = mid + 1;
            else
                end = mid - 1;
        }
        return end + 1;
    }
}


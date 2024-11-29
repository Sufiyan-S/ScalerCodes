















/*
Problem Description
Reverse the bits of an 32 bit unsigned integer A.

Output Format
Return a single unsigned integer denoting the decimal value of reversed bits.

Example Input
Input 1:
 0
Input 2:
 3

Example Output
Output 1:
 0
Output 2:
 3221225472

Example Explanation
Explanation 2:
        00000000000000000000000000000011    
=>      11000000000000000000000000000000
*/
class Solution {
    public long solve(long A) {
        long rev = 0;
        for(int i = 0; i < 32 ; i++) {
            rev <<= 1;
            if( (A & (1 << i) ) != 0)
                rev |= 1;
        }
        return rev;
    }
}


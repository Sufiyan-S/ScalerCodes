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


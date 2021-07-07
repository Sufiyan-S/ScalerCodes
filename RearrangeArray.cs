using System;
using System.Collections.Generic;

//Rearrange a given array so that Arr[i] becomes Arr[Arr[i]] with O(1) extra space.
class Solution {
    public void arrange(List<int> A) {
        int n=A.Count;
        for (int i = 0; i < n; i++)
            A[i] += (A[A[i]] % n) * n;
 
        // Second Step: Divide all values by n
        for (int i = 0; i < n; i++)
            A[i] /= n;
    }
}

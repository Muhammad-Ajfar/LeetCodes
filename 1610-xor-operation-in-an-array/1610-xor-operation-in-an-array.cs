public class Solution {
    public int XorOperation(int n, int start) {
        int res = start; // Initialize with start
        for (int i = 1; i < n; i++) { // Start loop from 1
            res ^= start + 2 * i;
        }
        return res;
    }
}
public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int whiteCount = 0;
        // Count 'W' in the first window of size k
        for (int i = 0; i < k; i++) {
            if (blocks[i] == 'W') whiteCount++;
        }
        
        int minOperations = whiteCount;

        // Slide the window
        for (int i = k; i < blocks.Length; i++) {
            if (blocks[i - k] == 'W') whiteCount--;
            if (blocks[i] == 'W') whiteCount++;

            minOperations = Math.Min(minOperations, whiteCount);
            if (minOperations == 0) return 0;
        }
        
        return minOperations;
    }
}

public class Solution {
    public int MaxIncreasingSubarrays(IList<int> nums) {
        int n = nums.Count;
        
        // Precompute the length of increasing sequence ending at each position
        int[] incr = new int[n];
        incr[0] = 1;
        
        for (int i = 1; i < n; i++) {
            if (nums[i] > nums[i - 1]) {
                incr[i] = incr[i - 1] + 1;
            } else {
                incr[i] = 1;
            }
        }
        
        // Precompute the length of increasing sequence starting at each position
        int[] decr = new int[n];
        decr[n - 1] = 1;
        
        for (int i = n - 2; i >= 0; i--) {
            if (nums[i] < nums[i + 1]) {
                decr[i] = decr[i + 1] + 1;
            } else {
                decr[i] = 1;
            }
        }
        
        int maxK = 0;
        
        // Check for all possible split points where the second subarray starts
        for (int split = 1; split < n; split++) {            
            
            int possibleK = Math.Min(incr[split-1], decr[split]);
            maxK = Math.Max(maxK, possibleK);
        }
        
        return maxK;
    }
}
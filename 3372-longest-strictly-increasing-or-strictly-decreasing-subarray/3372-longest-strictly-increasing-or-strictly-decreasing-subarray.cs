public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        int arrLen = nums.Length;
        int maxLen = 1;
        int start = 0;

        // Check for strictly increasing subarrays
        for (int end = 1; end < arrLen; end++) {
            if (nums[end] > nums[end - 1]) {
                maxLen = Math.Max(maxLen, end - start + 1);
            } else {
                start = end; // Reset start when the sequence breaks
            }
        }

        // Check for strictly decreasing subarrays
        start = 0;
        for (int end = 1; end < arrLen; end++) {
            if (nums[end] < nums[end - 1]) {
                maxLen = Math.Max(maxLen, end - start + 1);
            } else {
                start = end; // Reset start when the sequence breaks
            }
        }

        return maxLen;
    }
}
public class Solution {
    public int LongestNiceSubarray(int[] nums) {
        int left = 0;
        int bitmask = 0; 
        int maxLen = 0;

        for (int right = 0; right < nums.Length; right++) {
            while ((bitmask & nums[right]) != 0) {
                bitmask ^= nums[left];
                left++;
            }

            bitmask |= nums[right];

            maxLen = Math.Max(maxLen, right - left + 1);
        }

        return maxLen;
    }
}

public class Solution {
    public int LongestSubarray(int[] nums) {
        int max = 0;
        int curLen = 0, maxLen = 0;

        foreach (var num in nums) {
            if (num > max) {
                max = num;
                curLen = 1;
                maxLen = 1;
            } else if (num == max) {
                curLen++;
                maxLen = Math.Max(maxLen, curLen);
            } else {
                curLen = 0;
            }
        }

        return maxLen;
    }
}
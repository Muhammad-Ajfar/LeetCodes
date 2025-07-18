public class Solution {
    public int MaximumLength(int[] nums, int k) {
        int n = nums.Length;
        int[,] dp = new int[n + 1, k + 1];
        int longest = 0;

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < i; j++) {
                int mod = (nums[i] + nums[j]) % k;
                dp[i, mod] = Math.Max(dp[i, mod], dp[j, mod] + 1);
                longest = Math.Max(longest, dp[i, mod]);
            }
        }

        return longest + 1;
    }
}
public class Solution {
    public bool CanPartition(int[] nums) {
        int sum = 0;
        foreach (int num in nums)
            sum += num;

        if (sum % 2 != 0)
            return false;

        int target = sum / 2;
        int n = nums.Length;

        // dp[i] = true if a subset with sum i can be formed
        bool[] dp = new bool[target + 1];
        dp[0] = true;

        foreach (int num in nums) {
            // Traverse backwards to avoid using the same item more than once
            for (int i = target; i >= num; i--) {
                dp[i] = dp[i] || dp[i - num];
            }
        }

        return dp[target];
    }
}

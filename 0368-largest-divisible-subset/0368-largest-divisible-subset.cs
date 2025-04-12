public class Solution {
    public IList<int> LargestDivisibleSubset(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length;
        var dp = new List<int>[n];
        for (int i = 0; i < n; i++) dp[i] = new List<int>();

        List<int> maxSubset = new List<int>();

        for (int i = 0; i < n; i++) {
            List<int> best = new List<int>();

            for (int j = 0; j < i; j++) {
                if (nums[i] % nums[j] == 0 && dp[j].Count > best.Count) {
                    best = dp[j];
                }
            }

            // Clone best and add current number
            dp[i] = new List<int>(best);
            dp[i].Add(nums[i]);

            // Update maxSubset
            if (dp[i].Count > maxSubset.Count) {
                maxSubset = dp[i];
            }
        }

        return maxSubset;
    }
}

public class Solution {
    public long MostPoints(int[][] questions) {
        int n = questions.Length;
        long[] dp = new long[n + 1];

        for (int i = n - 1; i >= 0; i--) {
            int nextIndex = i + questions[i][1] + 1;
            long take = questions[i][0] + (nextIndex < n ? dp[nextIndex] : 0);
            long skip = dp[i + 1];

            dp[i] = Math.Max(take, skip);
        }

        return dp[0];
    }
}

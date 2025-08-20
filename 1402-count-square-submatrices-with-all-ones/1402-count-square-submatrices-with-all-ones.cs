public class Solution {
    public int CountSquares(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        var dp = new int[m, n];
        int count = 0;

        // Initialize first row and column
        for (int i = 0; i < m; i++) {
            dp[i, 0] = matrix[i][0];
            count += dp[i, 0];
        }
        for (int j = 1; j < n; j++) { // Start from 1 to avoid double counting [0,0]
            dp[0, j] = matrix[0][j];
            count += dp[0, j];
        }

        // Fill DP table
        for (int i = 1; i < m; i++) {
            for (int j = 1; j < n; j++) {
                if (matrix[i][j] == 1) {
                    dp[i, j] = 1 + Math.Min(Math.Min(dp[i-1, j], dp[i, j-1]), dp[i-1, j-1]);
                    count += dp[i, j];
                } else {
                    dp[i, j] = 0;
                }
            }
        }

        return count;
    }
}
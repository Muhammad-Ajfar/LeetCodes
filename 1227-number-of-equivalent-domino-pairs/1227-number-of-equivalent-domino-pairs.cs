public class Solution {
    public int NumEquivDominoPairs(int[][] dominoes) {
        int[,] dp = new int[10, 10];
        int count = 0;

        foreach (var domino in dominoes)
        {
            int a = Math.Min(domino[0], domino[1]);
            int b = Math.Max(domino[0], domino[1]);
            count += dp[a, b];
            dp[a, b]++;
        }

        return count;
    }
}

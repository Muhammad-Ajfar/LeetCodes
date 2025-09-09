public class Solution {
    public int PeopleAwareOfSecret(int n, int delay, int forget) {
        int MOD = 1000000007;
        long[] dp = new long[n + 1];  // dp[i] = number of new people learning on day i
        dp[1] = 1;  // On day 1, one person knows the secret

        for (int day = 2; day <= n; day++) {
            for (int prev = Math.Max(1, day - forget + 1); prev <= day - delay; prev++) {
                dp[day] = (dp[day] + dp[prev]) % MOD;
            }
        }

        long result = 0;
        // Count people who still remember the secret at day n
        for (int day = n - forget + 1; day <= n; day++) {
            if (day >= 1) {
                result = (result + dp[day]) % MOD;
            }
        }

        return (int)result;
    }
}
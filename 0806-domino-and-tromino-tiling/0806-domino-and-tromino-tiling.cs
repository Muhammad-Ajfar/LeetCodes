public class Solution {
    private const int MOD = 1000000007;

    public int NumTilings(int n) {
        var ways = new int[1001];
        ways[0] = 1;
        ways[1] = 1;
        ways[2] = 2;

        for (int i = 3; i <= n; i++) {
            long twoPreviousWays = 2L * ways[i - 1] % MOD;
            long threeBackWays = ways[i - 3];
            ways[i] = (int)((twoPreviousWays + threeBackWays) % MOD);
        }

        return ways[n];
    }
}

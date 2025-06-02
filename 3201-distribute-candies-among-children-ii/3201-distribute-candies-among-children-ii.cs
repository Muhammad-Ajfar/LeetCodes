public class Solution {
    public long DistributeCandies(int n, int limit) {
        return TotalWays(n) - (3 * TotalWays(n - (limit + 1))) + (3 * TotalWays(n - 2 * (limit + 1))) - TotalWays(n - 3 * (limit + 1));
    }
    
    private long TotalWays(int k) {
        if (k < 0) return 0;
        return (long)(k + 2) * (k + 1) / 2;
    }
}
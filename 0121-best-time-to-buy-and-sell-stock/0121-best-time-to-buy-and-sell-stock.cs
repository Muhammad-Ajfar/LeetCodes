public class Solution {
    public int MaxProfit(int[] prices) {
        int res = 0;
        int n = prices.Length;
        int minSoFar = prices[0];
        
        for (int i = 1; i < n; i++) {
            if (prices[i] < minSoFar) {
                minSoFar = prices[i];
            } else if (prices[i] > minSoFar) {
                res = Math.Max(res, prices[i] - minSoFar);
            }
        }
        
        return res;
    }
}
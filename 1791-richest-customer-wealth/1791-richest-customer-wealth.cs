public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int maxWealth = 0;
        int m = accounts.Length;
        
        for (int i = 0; i < m; i++) {
            int customerWealth = 0;
            int n = accounts[i].Length;
            
            for (int j = 0; j < n; j++) {
                customerWealth += accounts[i][j];
            }
            
            maxWealth = Math.Max(maxWealth, customerWealth);
        }
        
        return maxWealth;
    }
}
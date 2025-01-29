public class Solution {
    public int CountServers(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        int[] rows = new int[m];
        int[] cols = new int[n];

        // First pass: Count the number of servers in each row and column
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == 1) {
                    rows[i]++;
                    cols[j]++;
                }
            }
        }

        int count = 0;
        // Second pass: Count only servers that can communicate
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == 1 && (rows[i] > 1 || cols[j] > 1)) {
                    count++;
                }
            }
        }

        return count;
    }
}

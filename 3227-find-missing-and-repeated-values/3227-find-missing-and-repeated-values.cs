public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int len = grid.Length;
        int[] map = new int[len * len + 1];

        for (int i = 0; i < len; i++) {
            for (int j = 0; j < len; j++) {
                map[grid[i][j]]++; 
            }
        }

        int[] res = new int[2];

        for (int i = 1; i <= len * len; i++)
        {
            if (map[i] == 2) {
                res[0] = i; // Repeated number
            } else if (map[i] == 0) {
                res[1] = i; // Missing number
            }
        }

        return res;
    }
}
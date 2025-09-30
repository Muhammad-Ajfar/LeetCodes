public class Solution {
    public int[][] Transpose(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        
        int[][] result = new int[n][];
        for (int i = 0; i < n; i++) {
            result[i] = new int[m];
        }
        
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                result[j][i] = matrix[i][j];
            }
        }
        
        return result;
    }
}
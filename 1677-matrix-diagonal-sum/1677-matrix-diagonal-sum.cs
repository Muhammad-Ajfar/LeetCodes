public class Solution {
    public int DiagonalSum(int[][] mat) {
        int sum = 0;
        int len = mat.Length;

        for (int i = 0; i < len; i++) {
            sum += mat[i][i];  // Primary diagonal
            if (i != len - 1 - i) {  
                sum += mat[i][len - 1 - i]; // Secondary diagonal
            }
        }

        return sum;
    }
}
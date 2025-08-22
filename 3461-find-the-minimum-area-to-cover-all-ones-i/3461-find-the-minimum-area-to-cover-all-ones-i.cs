public class Solution {
    public int MinimumArea(int[][] grid) {

        int X1 = int.MaxValue;
        int X2 = int.MinValue;
        int Y1 = int.MaxValue;
        int Y2 = int.MinValue;

        for(int i = 0; i< grid.Length; i++)
        {
            for(int j = 0; j< grid[0].Length; j++)
            {
                if(grid[i][j] == 1)
                {
                    if(i < X1) X1 = i;
                    if(j < Y1) Y1 = j;

                    X2 = Math.Max(X2, i);
                    Y2 = Math.Max(Y2, j);
                }
            }
        }

        int l = X2 - X1 + 1;
        int b = Y2 - Y1 + 1;

        return l*b;
    }
}
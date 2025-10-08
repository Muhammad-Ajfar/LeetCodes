public class Solution
{
    public int[][] LargestLocal(int[][] grid)
    {
        int n = grid.Length;
        int len = n - 2;
        int[][] res = new int[len][];

        for (int i = 0; i < len; i++)
        {
            res[i] = new int[len];
            for (int j = 0; j < len; j++)
            {
                int maxVal = int.MinValue;
                for (int x = i; x < i + 3; x++)
                {
                    for (int y = j; y < j + 3; y++)
                    {
                        if (grid[x][y] > maxVal)
                            maxVal = grid[x][y];
                    }
                }

                res[i][j] = maxVal;
            }
        }

        return res;
    }
}
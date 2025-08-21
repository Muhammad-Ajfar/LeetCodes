public class Solution
{
    public int NumSubmat(int[][] mat)
    {
        int m = mat.Length;
        int n = mat[0].Length;
        var rows = new int[m, n];
        int res = 0;

        // Precompute consecutive ones row-wise
        for (int i = 0; i < m; i++)
        {
            int a = 0;
            for (int j = 0; j < n; j++)
            {
                if (mat[i][j] == 1) a++;
                else a = 0;

                rows[i, j] = a;
            }
        }

        // Count submatrices
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i][j] == 1)
                {
                    int min = int.MaxValue;
                    for (int k = i; k >= 0; k--)
                    {
                        min = Math.Min(rows[k, j], min);
                        res += min;
                    }
                }
            }
        }

        return res;
    }
}
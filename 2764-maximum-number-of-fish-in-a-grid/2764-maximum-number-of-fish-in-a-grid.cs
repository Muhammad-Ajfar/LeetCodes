public class Solution
{
    private static readonly int[] dRow = { -1, 1, 0, 0 };
    private static readonly int[] dCol = { 0, 0, -1, 1 };

    public int FindMaxFish(int[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        bool[,] visited = new bool[rows, cols];

        int maxFish = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] != 0 && !visited[i, j])
                {
                    int currentFishes = DFS(grid, visited, i, j);
                    maxFish = Math.Max(maxFish, currentFishes);
                }
            }
        }

        return maxFish;
    }

    private static int DFS(int[][] grid, bool[,] visited, int row, int col)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int currentFishes = 0;

        // Use a stack for DFS to avoid recursion depth issues
        Stack<(int, int)> stack = new Stack<(int, int)>();
        stack.Push((row, col));
        visited[row, col] = true;

        while (stack.Count > 0)
        {
            var (currentRow, currentCol) = stack.Pop();
            currentFishes += grid[currentRow][currentCol];

            for (int d = 0; d < 4; d++)
            {
                int newRow = currentRow + dRow[d];
                int newCol = currentCol + dCol[d];

                if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols &&
                    grid[newRow][newCol] != 0 && !visited[newRow, newCol])
                {
                    stack.Push((newRow, newCol));
                    visited[newRow, newCol] = true;
                }
            }
        }

        return currentFishes;
    }
}

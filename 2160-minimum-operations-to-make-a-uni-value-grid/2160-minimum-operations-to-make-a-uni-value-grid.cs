class Solution
{
    public int MinOperations(int[][] grid, int x)
    {
        int m = grid.Length, n = grid[0].Length;
        int[] arr = new int[m * n];

        // Flatten the grid into a 1D array
        int index = 0;
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                arr[index++] = grid[i][j];

        // Check if transformation is possible
        int baseValue = arr[0];
        foreach (int num in arr)
        {
            if ((num - baseValue) % x != 0)
                return -1;
        }

        // Sort and find the median
        Array.Sort(arr);
        int median = arr[arr.Length / 2];

        // Calculate operations to transform all values to the median
        int operations = arr.Sum(num => Math.Abs(num - median) / x);
        
        return operations;
    }
}

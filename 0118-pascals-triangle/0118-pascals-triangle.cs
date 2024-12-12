public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        // Initialize the Pascal's Triangle
        IList<IList<int>> pascal = new List<IList<int>>();

        for (int i = 0; i < numRows; i++) {
            // Create a new row
            IList<int> row = new List<int>();

            for (int j = 0; j <= i; j++) {
                // First and last elements of each row are always 1
                if (j == 0 || j == i) {
                    row.Add(1);
                } else {
                    // Add the sum of the two numbers above
                    row.Add(pascal[i - 1][j - 1] + pascal[i - 1][j]);
                }
            }

            // Add the row to Pascal's Triangle
            pascal.Add(row);
        }

        return pascal;
    }
}

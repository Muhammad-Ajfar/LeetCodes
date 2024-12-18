public class Solution {
    public IList<int> GetRow(int rowIndex) {
        IList<int> row = new List<int> { 1 };
        for (int i = 1; i <= rowIndex; i++) {
            row.Add((int)((long)row[i - 1] * (rowIndex - i + 1) / i));
        }
        return row;
    }
}
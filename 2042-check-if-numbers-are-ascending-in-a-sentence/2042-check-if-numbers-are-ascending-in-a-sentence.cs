public class Solution {
    public bool AreNumbersAscending(string s) {
        int prev = -1;
        foreach (var token in s.Split(' ')) {
            if (int.TryParse(token, out int num)) {
                if (num <= prev) return false;
                prev = num;
            }
        }
        return true;
    }
}
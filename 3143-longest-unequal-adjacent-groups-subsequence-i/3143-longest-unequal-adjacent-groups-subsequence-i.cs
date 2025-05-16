public class Solution {
    public IList<string> GetLongestSubsequence(string[] words, int[] groups) {
        int n = words.Length;
        var a = new List<string>(); // alt starting with 0
        var b = new List<string>(); // alt starting with 1
        int p = 1, q = 0;

        for (int i = 0; i < n; i++) {
            if (groups[i] != p) {
                a.Add(words[i]);
                p = groups[i];
            }
            if (groups[i] != q) {
                b.Add(words[i]);
                q = groups[i];
            }
        }

        return a.Count >= b.Count ? a : b;
    }
}

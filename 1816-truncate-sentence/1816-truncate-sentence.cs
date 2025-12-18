public class Solution {
    public string TruncateSentence(string s, int k) {
        var sb = new StringBuilder();
        int wordCount = 0;

        for (int i = 0; i < s.Length; i++) {
            if (s[i] == ' ') {
                wordCount++;
                if (wordCount == k) break;
            }
            sb.Append(s[i]);
        }

        return sb.ToString();
    }
}
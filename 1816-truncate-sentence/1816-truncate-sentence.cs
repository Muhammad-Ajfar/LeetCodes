public class Solution {
    public string TruncateSentence(string s, int k) {
        int spaces = 0;
        int i;

        for (i = 0; i < s.Length; i++) {
            if (s[i] == ' ') {
                spaces++;
                if (spaces == k) break;
            }
        }

        return spaces == k ? s.Substring(0, i) : s;
    }
}
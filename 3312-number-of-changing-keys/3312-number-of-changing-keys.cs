public class Solution {
    public int CountKeyChanges(string s) {
        if (string.IsNullOrEmpty(s)) return 0;

        int count = 0;
        char prev = char.ToLower(s[0]);

        for (int i = 1; i < s.Length; i++) {
            char curr = char.ToLower(s[i]);
            if (curr != prev) {
                count++;
                prev = curr;
            }
        }

        return count;
    }
}

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int res = 0;
        int left = 0;
        var uniq = new HashSet<char>();

        for (int right = 0; right < s.Length; right++) {
            char c = s[right];

            if (uniq.Contains(c)) {
                res = Math.Max(res, right - left);

                while (s[left] != c) {
                    uniq.Remove(s[left]);
                    left++;
                }

                // Remove the duplicate itself
                uniq.Remove(s[left]);
                left++;
            }

            uniq.Add(c);
        }

        // Final check
        res = Math.Max(res, s.Length - left);

        return res;
    }
}
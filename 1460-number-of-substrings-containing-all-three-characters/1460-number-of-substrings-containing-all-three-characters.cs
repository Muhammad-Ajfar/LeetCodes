public class Solution {
    public int NumberOfSubstrings(string s) {
        int n = s.Length;
        int res = 0;
        int right = 0;
        int[] freq = new int[3]; // Frequency array for 'a', 'b', 'c'
        int uniqueAbc = 0;

        for (int left = 0; left < n; left++) {
            while (right < n && uniqueAbc < 3) {
                if (freq[s[right] - 'a'] == 0) uniqueAbc++;
                freq[s[right] - 'a']++;
                right++;
            }

            if (uniqueAbc == 3) {
                res += n - right + 1; // Count valid substrings
            }

            freq[s[left] - 'a']--;
            if (freq[s[left] - 'a'] == 0) {
                uniqueAbc--;
            }
        }

        return res;
    }
}

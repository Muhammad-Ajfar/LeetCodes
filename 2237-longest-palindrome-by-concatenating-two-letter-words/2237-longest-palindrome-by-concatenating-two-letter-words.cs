public class Solution {
    public int LongestPalindrome(string[] words) {
        var freq = new Dictionary<string, int>();
        int result = 0;
        bool hasOddSymmetric = false;

        foreach (string word in words) {
            if (!freq.ContainsKey(word)) {
                freq[word] = 0;
            }
            freq[word]++;
        }

        foreach (var kvp in freq) {
            string word = kvp.Key;
            int count = kvp.Value;
            if (word[0] == word[1]) {
                result += (count / 2) * 4;
                if (count % 2 == 1) {
                    hasOddSymmetric = true;
                }
            } else {
                string rev = new string(new char[] { word[1], word[0] });
                if (freq.ContainsKey(rev)) {
                    int revCount = freq[rev];
                    int min = Math.Min(count, revCount);
                    if (word.CompareTo(rev) < 0) {
                        result += min * 4;
                    }
                }
            }
        }

        if (hasOddSymmetric) {
            result += 2;
        }

        return result;
    }
}
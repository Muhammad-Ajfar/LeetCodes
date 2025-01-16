public class Solution {
    public IList<string> WordSubsets(string[] words1, string[] words2) {
        List<string> res = new List<string>();
        int[] maxFrequencies = new int[26];

        // Build max frequency array for words2
        foreach (string word in words2) {
            int[] freq = new int[26];
            foreach (char c in word) {
                freq[c - 'a']++;
            }
            for (int i = 0; i < 26; i++) {
                maxFrequencies[i] = Math.Max(maxFrequencies[i], freq[i]);
            }
        }

        // Check each word in words1
        foreach (string word in words1) {
            int[] freq = new int[26];
            foreach (char c in word) {
                freq[c - 'a']++;
            }
            bool isUniversal = true;
            for (int i = 0; i < 26; i++) {
                if (freq[i] < maxFrequencies[i]) {
                    isUniversal = false;
                    break;
                }
            }
            if (isUniversal) {
                res.Add(word);
            }
        }

        return res;
    }
}

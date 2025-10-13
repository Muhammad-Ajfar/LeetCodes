public class Solution {
    public IList<string> RemoveAnagrams(string[] words) {
        List<string> result = new List<string>();
        
        result.Add(words[0]);
        
        for (int i = 1; i < words.Length; i++) {
            if (!IsAnagram(words[i-1], words[i])) {
                result.Add(words[i]);
            }
        }
        
        return result;
    }
    
    private bool IsAnagram(string word1, string word2) {
        if (word1.Length != word2.Length) return false;
        
        int[] charCount = new int[26];
        
        foreach (char c in word1) {
            charCount[c - 'a']++;
        }
        
        foreach (char c in word2) {
            charCount[c - 'a']--;
        }
        
        for (int i = 0; i < 26; i++) {
            if (charCount[i] != 0) return false;
        }
        
        return true;
    }
}
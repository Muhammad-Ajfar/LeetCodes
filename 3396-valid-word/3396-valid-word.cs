public class Solution {
    public bool IsValid(string word) {
        var vowels = new HashSet<char> { 'a','e','i','o','u','A','E','I','O','U' };
        var invalid = new HashSet<char> { '@','#','$' };

        if (word.Length < 3) return false;

        bool hasVowel = false, hasConsonant = false;

        foreach (char ch in word) {
            if (invalid.Contains(ch)) return false;

            if (ch > '9') { // All letters are > '9' in ASCII
                if (vowels.Contains(ch)) hasVowel = true;
                else hasConsonant = true;
            }
        }

        return hasVowel && hasConsonant;
    }
}
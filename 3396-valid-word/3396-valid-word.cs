public class Solution {
    public bool IsValid(string word) {
        if (word.Length < 3) return false;

        bool hasVowel = false, hasConsonant = false;

        foreach (char ch in word) {
            // Check for invalid chars (@, #, $) using ASCII ranges
            if (ch == 64 || ch == 35 || ch == 36) return false; // @=64, #=35, $=36

            if(ch > '9'){
                // Check for vowels (A=65, E=69, I=73, O=79, U=85, a=97, e=101, i=105, o=111, u=117)
                if ((ch | 32) == 'a' || (ch | 32) == 'e' || (ch | 32) == 'i' || (ch | 32) == 'o' || (ch | 32) == 'u') {
                    hasVowel = true;
                }
                // Check for consonants (A-Za-z not vowels)
                else if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z')) {
                    hasConsonant = true;
                }
            }
        }

        return hasVowel && hasConsonant;
    }
}
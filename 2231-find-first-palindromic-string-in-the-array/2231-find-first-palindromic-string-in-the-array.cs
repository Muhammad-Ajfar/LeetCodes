public class Solution {
    public string FirstPalindrome(string[] words) {
        foreach (string word in words) {
            if (IsPalindrome(word)) {
                return word;
            }
        }
        return "";
    }
    
    private bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;
        while (left < right) {
            if (s[left] != s[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
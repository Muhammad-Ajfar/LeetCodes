public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder sb = new StringBuilder();
        foreach (char ch in s) {
            if (Char.IsLetterOrDigit(ch)) {
                sb.Append(Char.ToLower(ch));
            }
        }

        string filtered = sb.ToString();
        int left = 0, right = filtered.Length - 1;

        while (left < right) {
            if (filtered[left] != filtered[right]) {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}

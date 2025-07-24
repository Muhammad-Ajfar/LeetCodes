public class Solution {
    public string RemoveOuterParentheses(string s) {
        StringBuilder result = new StringBuilder();
        int balance = 0;
        int start = 0;
        
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(') {
                balance++;
            } else {
                balance--;
            }
            
            if (balance == 0) {
                result.Append(s.Substring(start + 1, i - start - 1));
                start = i + 1;
            }
        }
        
        return result.ToString();
    }
}
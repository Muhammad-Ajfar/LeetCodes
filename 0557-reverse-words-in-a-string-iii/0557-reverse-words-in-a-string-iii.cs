public class Solution {
    public string ReverseWords(string s) {
        char[] chars = s.ToCharArray();
        int start = 0;
        
        for (int i = 0; i <= chars.Length; i++) {
            if (i == chars.Length || chars[i] == ' ') {
                Reverse(chars, start, i - 1);
                start = i + 1;
            }
        }
        
        return new string(chars);
    }
    
    private void Reverse(char[] chars, int left, int right) {
        while (left < right) {
            char temp = chars[left];
            chars[left] = chars[right];
            chars[right] = temp;
            left++;
            right--;
        }
    }
}
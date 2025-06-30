public class Solution {
    public int LongestSubsequence(string s, int k) {
        int n = s.Length;
        int val = 0;
        int onesRemoved = 0;
        
        for (int i = n - 1; i >= 0; i--) {
            if (n - 1 - i >= 30 && s[i] == '1') {
                onesRemoved++;
            }
            else if (s[i] == '1') {
                int bitVal = 1 << (n - 1 - i);
                if (val + bitVal > k) {
                    onesRemoved++;
                } else {
                    val += bitVal;
                }
            }
        }
        return n - onesRemoved;
    }
}
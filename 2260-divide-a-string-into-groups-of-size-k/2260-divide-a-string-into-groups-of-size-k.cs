public class Solution {
    public string[] DivideString(string s, int k, char fill) {
        int length = s.Length;
        int groups = (length + k - 1) / k; // Calculate number of groups needed
        string[] result = new string[groups];
        
        for (int i = 0; i < groups; i++) {
            int start = i * k;
            if (start + k <= length) {
                result[i] = s.Substring(start, k);
            } else {
                int remaining = length - start;
                result[i] = s.Substring(start, remaining) + 
                    new string(fill, k - remaining);
            }
        }
        
        return result;
    }
}
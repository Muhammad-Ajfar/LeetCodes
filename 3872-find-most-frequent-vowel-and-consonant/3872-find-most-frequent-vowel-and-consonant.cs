public class Solution {
    public int MaxFreqSum(string s) {
        HashSet<char> vowels = new HashSet<char>{'a','e','i','o','u'};
        int[] freq = new int[26];
        int vMax = 0;
        int cMax = 0;

        foreach(char c in s) {
            freq[c - 'a']++;

            if(vowels.Contains(c))
                vMax = Math.Max(vMax, freq[c - 'a']);
            else
                cMax = Math.Max(cMax, freq[c - 'a']);
        }

        return cMax + vMax;
    }
}
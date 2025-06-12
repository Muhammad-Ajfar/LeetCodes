public class Solution {
    public int MaxDifference(string s) {
        int[] freq = new int[26];
        int minEvenFreq = int.MaxValue;
        int maxOddFreq = 0;
        foreach(char ch in s) freq[ch - 'a']++;

        foreach(int f in freq)
        {
            if(f == 0) continue;
            if(f % 2 == 1) maxOddFreq = Math.Max(maxOddFreq, f);
            else minEvenFreq = Math.Min(minEvenFreq, f);
        }

        return maxOddFreq - minEvenFreq;
    }
}
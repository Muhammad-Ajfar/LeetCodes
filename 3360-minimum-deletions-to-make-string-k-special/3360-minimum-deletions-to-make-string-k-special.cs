public class Solution {
    public int MinimumDeletions(string word, int k) {
        var freq = new Dictionary<char, int>();
        
        foreach (var c in word) {
            if (!freq.ContainsKey(c))
                freq[c] = 0;
            freq[c]++;
        }

        var freqValues = freq.Values.ToList();
        freqValues.Sort();

        int minDeletions = int.MaxValue;

        // Try every possible target frequency from 1 to max(freq)
        for (int target = 1; target <= freqValues[^1]; target++) {
            int deletions = 0;

            foreach (var f in freqValues) {
                if (f > target + k)
                    deletions += f - (target + k);
                else if (f < target)
                    deletions += f;
                // else: f in [target, target + k] -> OK
            }

            minDeletions = Math.Min(minDeletions, deletions);
        }

        return minDeletions;
    }
}

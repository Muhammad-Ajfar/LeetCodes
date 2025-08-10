public class Solution {
    public bool ReorderedPowerOf2(int n) {
        // Precompute all powers of two within range
        HashSet<string> powerOfTwoSignatures = new HashSet<string>();
        for (int i = 1; i <= 1_000_000_000; i <<= 1) {
            var sortedDigits = String.Concat(i.ToString().OrderBy(c => c));
            powerOfTwoSignatures.Add(sortedDigits);
        }

        // Sort the digits of n and check if present in precomputed set
        var nSorted = String.Concat(n.ToString().OrderBy(c => c));
        return powerOfTwoSignatures.Contains(nSorted);
    }
}

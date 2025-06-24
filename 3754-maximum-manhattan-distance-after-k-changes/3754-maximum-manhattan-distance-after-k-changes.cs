public class Solution {
    public int MaxDistance(string s, int k) {
        int N = 0, S = 0, E = 0, W = 0;
        int outputMax = 0;

        foreach (char c in s) {
            switch (c) {
                case 'N': N++; break;
                case 'S': S++; break;
                case 'E': E++; break;
                case 'W': W++; break;
            }

            int verticalDiff = Math.Abs(N - S);
            int horizontalDiff = Math.Abs(E - W);
            int extraGain = 2 * Math.Min(k, Math.Min(N, S) + Math.Min(E, W));

            outputMax = Math.Max(outputMax, verticalDiff + horizontalDiff + extraGain);
        }

        return outputMax;
    }
}

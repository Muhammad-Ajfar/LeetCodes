public class Solution {
    public int MinDominoRotations(int[] tops, int[] bottoms) {
        int n = tops.Length;
        int result = Check(tops[0], tops, bottoms, n);
        if (result != -1) return result;
        return Check(bottoms[0], tops, bottoms, n);
    }

    private int Check(int target, int[] tops, int[] bottoms, int n) {
        int topRotations = 0;
        int bottomRotations = 0;

        for (int i = 0; i < n; i++) {
            if (tops[i] != target && bottoms[i] != target) {
                return -1;
            } else if (tops[i] != target) {
                topRotations++;
            } else if (bottoms[i] != target) {
                bottomRotations++;
            }
        }

        return Math.Min(topRotations, bottomRotations);
    }
}

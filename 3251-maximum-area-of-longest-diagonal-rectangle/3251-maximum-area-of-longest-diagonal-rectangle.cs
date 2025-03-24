public class Solution {
    public int AreaOfMaxDiagonal(int[][] dimensions) {
        int curMaxSq = 0;
        int curMaxArea = 0;

        foreach (int[] rect in dimensions) {
            int curArea = rect[0] * rect[1];
            int sumSq = (rect[0] * rect[0]) + (rect[1] * rect[1]);

            if (sumSq > curMaxSq) {
                curMaxSq = sumSq;
                curMaxArea = curArea;
            } else if (sumSq == curMaxSq) {
                curMaxArea = Math.Max(curMaxArea, curArea);
            }
        }

        return curMaxArea;
    }
}

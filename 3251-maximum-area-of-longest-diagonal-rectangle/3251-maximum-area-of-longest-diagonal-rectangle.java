class Solution {
    public int areaOfMaxDiagonal(int[][] dimensions) {
        int curMaxSq = 0;
        int curMaxArea = 0;
        
        for (int[] rect : dimensions) {
            int curArea = rect[0] * rect[1];
            int sumSq = (rect[0] * rect[0]) + (rect[1] * rect[1]);
            
            if (sumSq > curMaxSq) {
                curMaxSq = sumSq;
                curMaxArea = curArea;
            } else if (sumSq == curMaxSq) {
                curMaxArea = Math.max(curMaxArea, curArea);
            }
        }
        
        return curMaxArea;
    }
}
public class Solution {
    public int MaxScoreSightseeingPair(int[] values) {
        int maxScore = 0;
        int maxLeft = values[0]; // value[0] + 0

        for (int j = 1; j < values.Length; j++) {
            // Calculate the score for the current pair
            maxScore = Math.Max(maxScore, maxLeft + values[j] - j);

            // Update maxLeft for the next iteration
            maxLeft = Math.Max(maxLeft, values[j] + j);
        }

        return maxScore;
    }
}

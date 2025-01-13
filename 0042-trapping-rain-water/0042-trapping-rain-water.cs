public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;

        // If the array has less than 3 bars, no water can be trapped.
        if (n < 3) return 0;

        // Arrays to store the maximum height to the left and right of each bar.
        int[] maxLeft = new int[n];
        int[] maxRight = new int[n];

        int totalWater = 0;

        // Set the first and last values of the max arrays
        maxLeft[0] = height[0];
        maxRight[n - 1] = height[n - 1];

        // Fill the maxLeft array: max height to the left of each bar.
        for (int i = 1; i < n; i++) {
            maxLeft[i] = Math.Max(maxLeft[i - 1], height[i]);
        }

        // Fill the maxRight array: max height to the right of each bar.
        for (int i = n - 2; i >= 0; i--) {
            maxRight[i] = Math.Max(maxRight[i + 1], height[i]);
        }

        for (int i = 1; i < n - 1; i++) {
            // Water above current bar is determined by the smaller of maxLeft and maxRight.
            int waterAboveBar = Math.Min(maxLeft[i], maxRight[i]) - height[i];

            totalWater += waterAboveBar;
        }

        return totalWater;
    }
}

public class Solution {
    public long MaximumTripletValue(int[] nums) {
        int n = nums.Length;
        int[] maxLeft = new int[n - 2];
        int[] maxRight = new int[n - 2];

        maxLeft[0] = nums[0];
        for (int i = 1; i < n - 2; i++) {
            maxLeft[i] = Math.Max(maxLeft[i - 1], nums[i]);
        }

        maxRight[n - 3] = nums[n - 1];
        for (int i = n - 4; i >= 0; i--) {
            maxRight[i] = Math.Max(maxRight[i + 1], nums[i + 2]);
        }

        long maxVal = 0;
        for (int j = 1; j < n - 1; j++) {
            maxVal = Math.Max(maxVal,
                (long)(maxLeft[j - 1] - nums[j]) * maxRight[j - 1]);
        }

        return maxVal;
    }
}

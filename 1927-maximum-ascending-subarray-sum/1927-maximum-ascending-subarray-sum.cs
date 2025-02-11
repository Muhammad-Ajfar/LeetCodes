public class Solution {
    public int MaxAscendingSum(int[] nums) {
        int arrLen = nums.Length;
        int maxSum = nums[0];
        int tempSum = nums[0];

        for (int end = 1; end < arrLen; end++) {
            if (nums[end] > nums[end - 1]) {
                tempSum += nums[end];
            } else {
                maxSum = Math.Max(maxSum, tempSum);
                tempSum = nums[end];
            }
        }

        return Math.Max(maxSum, tempSum);
    }
}

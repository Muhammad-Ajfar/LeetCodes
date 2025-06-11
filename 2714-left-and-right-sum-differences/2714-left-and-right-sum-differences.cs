public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        int n = nums.Length;
        int[] leftSum = new int[n];
        int[] rightSum = new int[n];
        int[] answer = new int[n];

        // Build leftSum
        for (int i = 1; i < n; i++) {
            leftSum[i] = leftSum[i - 1] + nums[i - 1];
        }

        // Build rightSum
        for (int i = n - 2; i >= 0; i--) {
            rightSum[i] = rightSum[i + 1] + nums[i + 1];
        }

        // Build answer
        for (int i = 0; i < n; i++) {
            answer[i] = Math.Abs(leftSum[i] - rightSum[i]);
        }

        return answer;
    }
}

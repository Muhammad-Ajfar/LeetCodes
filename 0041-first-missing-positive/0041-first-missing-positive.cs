public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int n = nums.Length;

        // Step 1: Place each number in its correct position
        for (int i = 0; i < n; i++) {
            // Keep swapping until nums[i] is in its correct position or out of range
            while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i]) {
                Swap(nums, i, nums[i] - 1);
            }
        }

        // Step 2: Identify the first missing positive
        for (int i = 0; i < n; i++) {
            if (nums[i] != i + 1) {
                return i + 1;
            }
        }

        // If all numbers from 1 to n are in their correct positions
        return n + 1;
    }

    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}

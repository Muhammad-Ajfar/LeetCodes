public class Solution {
    public long CountFairPairs(int[] nums, int lower, int upper) {
        Array.Sort(nums);
        long count = 0;

        for (int i = 0; i < nums.Length - 1; i++) {
            int left = i + 1;
            int right = nums.Length - 1;

            while (left <= right) {
                int mid = left + (right - left) / 2;
                if (nums[i] + nums[mid] >= lower) {
                    right = mid - 1;
                } else {
                    left = mid + 1;
                }
            }

            int lowerBoundIndex = left;

            right = nums.Length - 1;

            while (left <= right) {
                int mid = left + (right - left) / 2;
                if (nums[i] + nums[mid] <= upper) {
                    left = mid + 1;
                } else {
                    right = mid - 1;
                }
            }

            int upperBoundIndex = right;

            count += upperBoundIndex - lowerBoundIndex + 1;
        }

        return count;
    }
}

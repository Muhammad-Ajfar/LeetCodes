public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        int count = 0;

        for (int i = 0; i < nums.Length; i++) {
            int second = nums[i] + diff;
            int third = nums[i] + 2 * diff;

            // Check if the second and third values exist using binary search
            if (Array.BinarySearch(nums, second) >= 0 && Array.BinarySearch(nums, third) >= 0) {
                count++;
            }
        }

        return count;
    }
}

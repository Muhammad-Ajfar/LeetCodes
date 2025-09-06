public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;
        
        while (left < right) {
            // Find first odd number from left
            while (left < right && nums[left] % 2 == 0) {
                left++;
            }
            
            // Find first even number from right
            while (left < right && nums[right] % 2 == 1) {
                right--;
            }
            
            // Swap them
            if (left < right) {
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                left++;
                right--;
            }
        }
        
        return nums;
    }
}
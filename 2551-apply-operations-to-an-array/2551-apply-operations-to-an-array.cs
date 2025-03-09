public class Solution {
    public int[] ApplyOperations(int[] nums) {
        int n = nums.Length;
        int index = 0;

        for (int i = 0; i < n; i++) {
            if (i < n - 1 && nums[i] == nums[i + 1]) {
                nums[i] *= 2;
                nums[i + 1] = 0;
            }
            if (nums[i] != 0) {
                nums[index++] = nums[i];
            }
        }

        while (index < n) {
            nums[index++] = 0;
        }

        return nums;
    }
}

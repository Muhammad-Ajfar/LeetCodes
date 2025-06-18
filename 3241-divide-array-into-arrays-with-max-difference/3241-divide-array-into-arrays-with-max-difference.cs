public class Solution {
    public int[][] DivideArray(int[] nums, int k) {
        int n = nums.Length;
        int m = n / 3;
        Array.Sort(nums);
        var res = new int[m][];
        for (int i = 0, j = 0; i < n; i += 3, j++) {
            if (nums[i + 2] - nums[i] > k) 
                return [];
            res[j] = [nums[i], nums[i + 1], nums[i + 2]];
        }
        return res;
    }
}
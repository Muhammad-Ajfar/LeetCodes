public class Solution {
    public int MaximumDifference(int[] nums) {
        int res = -1;
        int n = nums.Length;
        int minSoFar = nums[0];
        
        for (int i = 1; i < n; i++) {
            if (nums[i] < minSoFar) {
                minSoFar = nums[i];
            } else if (nums[i] > minSoFar) {
                res = Math.Max(res, nums[i] - minSoFar);
            }
        }
        
        return res;
    }
}
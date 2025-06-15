public class Solution {
    public int MaxAdjacentDistance(int[] nums) {
        int n = nums.Length;
        int max = Math.Abs(nums[0] - nums[n - 1]);
        
        for (int i = 1; i < n; i++) 
        {
            max = Math.Max(max, Math.Abs(nums[i] - nums[i - 1]));
        }
        
        return max;
    }
}
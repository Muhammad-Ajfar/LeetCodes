public class Solution {
    public int SubsetXORSum(int[] nums) {
        return Dfs(nums, 0, 0);
    }
    
    private int Dfs(int[] nums, int index, int currentXor) {
        if (index == nums.Length) {
            return currentXor;
        }
    
        // Include nums[index]
        int with = Dfs(nums, index + 1, currentXor ^ nums[index]);
    
        // Exclude nums[index]
        int without = Dfs(nums, index + 1, currentXor);
    
        return with + without;
    }

}
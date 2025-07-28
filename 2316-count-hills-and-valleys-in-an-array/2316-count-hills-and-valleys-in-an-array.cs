public class Solution {
    public int CountHillValley(int[] nums) {
        int count = 0;
        List<int> filtered = new List<int>();
        filtered.Add(nums[0]);
        
        // Remove consecutive duplicates
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[i-1]) {
                filtered.Add(nums[i]);
            }
        }
        
        // Check for hills and valleys
        for (int i = 1; i < filtered.Count - 1; i++) {
            if ( (filtered[i] > filtered[i-1]) == (filtered[i] > filtered[i+1]) ) {
                count++;
            }
        }
        
        return count;
    }
}
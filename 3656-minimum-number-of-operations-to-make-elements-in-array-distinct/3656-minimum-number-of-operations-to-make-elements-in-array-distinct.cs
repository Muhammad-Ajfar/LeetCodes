public class Solution {
    public int MinimumOperations(int[] nums) {
        int operations = 0;
        int n = nums.Length;
        int start = 0;
        
        while (start < n) {
            if (HasDuplicates(nums, start, n - 1)) {
                operations++;
                start += 3;
            } else {
                break;
            }
        }
        
        return operations;
    }
    
    private bool HasDuplicates(int[] nums, int start, int end) {
        int[] freq = new int[101];
        for (int i = start; i <= end; i++) {
            if (freq[nums[i]] > 0) {
                return true;
            }
            freq[nums[i]]++;
        }
        return false;
    }
}
public class Solution {
    public int MinimizeMax(int[] nums, int p) {
        if (p == 0) return 0;
        
        Array.Sort(nums);
        int left = 0;
        int right = nums[nums.Length - 1] - nums[0];
        int result = right;
        
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (CanFormPairs(nums, p, mid)) {
                result = mid;
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }
        
        return result;
    }
    
    private bool CanFormPairs(int[] nums, int p, int maxDiff) {
        int count = 0;
        int i = 0;
        while (i < nums.Length - 1) {
            if (nums[i + 1] - nums[i] <= maxDiff) {
                count++;
                i += 2;
            } else {
                i++;
            }
            if (count >= p) {
                return true;
            }
        }
        return count >= p;
    }
}
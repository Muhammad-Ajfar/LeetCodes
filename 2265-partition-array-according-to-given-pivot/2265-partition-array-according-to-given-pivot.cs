public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        int n = nums.Length;
        int[] res = new int[n];
        int left = 0;
        int right = n - 1;
        int pivotCount = 0;
        
        for (int i = 0; i < n; i++) {
            if (nums[i] < pivot) {
                res[left++] = nums[i];
            } else if (nums[i] == pivot) {
                pivotCount++;
            }
        }
        
        for (int i = n - 1; i >= 0; i--) {
            if (nums[i] > pivot) {
                res[right--] = nums[i];
            }
        }
        
        while (pivotCount-- > 0) {
            res[left++] = pivot;
        }
        
        return res;
    }
}

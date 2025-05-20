public class Solution {
    public bool IsZeroArray(int[] nums, int[][] queries) {
        int n = nums.Length;
        int[] diff = new int[n + 1];
        
        foreach (var query in queries) {
            int l = query[0];
            int r = query[1];
            diff[l]++;
            if (r + 1 < n) {
                diff[r + 1]--;
            }
        }
        
        int current = 0;
        for (int i = 0; i < n; i++) {
            current += diff[i];
            if (current < nums[i]) {
                return false;
            }
        }
        
        return true;
    }
}
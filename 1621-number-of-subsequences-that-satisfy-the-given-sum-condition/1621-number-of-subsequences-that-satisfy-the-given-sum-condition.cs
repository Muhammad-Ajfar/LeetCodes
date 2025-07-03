public class Solution {
    public int NumSubseq(int[] nums, int target) {
        Array.Sort(nums);
        int n = nums.Length;
        int MOD = 1000000007;
        int res = 0;
        
        // Precompute powers of 2 modulo MOD up to n
        int[] pow2 = new int[n + 1];
        pow2[0] = 1;
        for (int i = 1; i <= n; i++) {
            pow2[i] = (pow2[i - 1] * 2) % MOD;
        }
        
        int left = 0;
        int right = n - 1;
        
        while (left <= right) {
            if (nums[left] + nums[right] > target) {
                right--;
            } else {
                res = (res + pow2[right - left]) % MOD;
                left++;
            }
        }
        
        return res;
    }
}
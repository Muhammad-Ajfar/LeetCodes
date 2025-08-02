public class Solution {
    public int MissingNumber(int[] nums) {
        int xor = 0, n = nums.Length;
        for (int i = 0; i < n; i++) {
            xor ^= i ^ nums[i];
        }
        return xor ^ n;
    }
}
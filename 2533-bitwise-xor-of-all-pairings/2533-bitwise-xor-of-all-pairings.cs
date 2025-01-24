public class Solution {
    public int XorAllNums(int[] nums1, int[] nums2) {
        int xorNums1 = 0, xorNums2 = 0;

        // XOR all elements in nums1 and nums2
        foreach (int num in nums1) xorNums1 ^= num;
        foreach (int num in nums2) xorNums2 ^= num;

        // XOR contribution from nums1 if nums2.Length is odd
        int result = (nums2.Length % 2 == 1) ? xorNums1 : 0;

        // XOR contribution from nums2 if nums1.Length is odd
        result ^= (nums1.Length % 2 == 1) ? xorNums2 : 0;

        return result;
    }
}

public class Solution {
    public int MaximumLength(int[] nums) {
        int even = 0, odd = 0, altLen = 1;
        int last = nums[0] & 1;

        foreach (int num in nums) {
            int parity = num & 1;

            if (parity == 0) ++even;
            else ++odd;

            if (parity != last) {
                ++altLen;
                last = parity;
            }
        }

        return Math.Max(altLen, Math.Max(even, odd));
    }
}
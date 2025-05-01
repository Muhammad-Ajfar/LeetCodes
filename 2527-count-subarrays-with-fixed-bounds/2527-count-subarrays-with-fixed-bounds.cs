using System;

public class Solution {
    public long CountSubarrays(int[] nums, int minK, int maxK) {
        long result = 0;
        int lastMin = -1, lastMax = -1, lastInvalid = -1;
        
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == minK) lastMin = i;
            if (nums[i] == maxK) lastMax = i;
            if (nums[i] < minK || nums[i] > maxK) lastInvalid = i;
            
            if (lastMin != -1 && lastMax != -1) {
                int lowerBound = Math.Min(lastMin, lastMax);
                if (lowerBound > lastInvalid) {
                    result += lowerBound - lastInvalid;
                }
            }
        }
        return result;
    }
}
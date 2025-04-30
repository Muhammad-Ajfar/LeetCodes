using System;
using System.Collections.Generic;

public class Solution {
    public long CountInterestingSubarrays(IList<int> nums, int modulo, int k) {
        int n = nums.Count;
        int[] prefixMod = new int[n + 1];
        Dictionary<int, int> modCount = new Dictionary<int, int>();
        modCount[0] = 1;
        long result = 0;
        
        for (int i = 0; i < n; i++) {
            int num = nums[i];
            int add = (num % modulo == k) ? 1 : 0;
            prefixMod[i + 1] = (prefixMod[i] + add) % modulo;
            
            // We need (currentMod - x) ≡ k mod modulo => x ≡ (currentMod - k) mod modulo
            int target = (prefixMod[i + 1] - k) % modulo;
            if (target < 0) target += modulo; // Ensure it's positive
            
            if (modCount.ContainsKey(target)) {
                result += modCount[target];
            }
            
            // Update the modCount with the current prefixMod[i+1]
            int current = prefixMod[i + 1];
            if (modCount.ContainsKey(current)) {
                modCount[current]++;
            } else {
                modCount[current] = 1;
            }
        }
        
        return result;
    }
}
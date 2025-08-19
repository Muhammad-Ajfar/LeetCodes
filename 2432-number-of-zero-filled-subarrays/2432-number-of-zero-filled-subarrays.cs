public class Solution {
    public long ZeroFilledSubarray(int[] nums) {
        long totalZeroSubarrays = 0;
        int consecutiveZeros = 0;
        
        foreach (int num in nums) {
            if (num == 0) {
                consecutiveZeros++;
                totalZeroSubarrays += consecutiveZeros;
            }
            else consecutiveZeros = 0;
        }
        
        return totalZeroSubarrays;
    }
}
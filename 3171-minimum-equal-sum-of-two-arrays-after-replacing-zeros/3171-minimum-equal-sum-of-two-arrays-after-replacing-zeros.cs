public class Solution {
    public long MinSum(int[] nums1, int[] nums2) {
        GetSumAndZeroCount(nums1, out long sum1, out int z1);
        GetSumAndZeroCount(nums2, out long sum2, out int z2);
        
        long minSum1 = sum1 + z1;
        long minSum2 = sum2 + z2;
        
        if (z1 == 0 && z2 == 0) {
            return sum1 == sum2 ? sum1 : -1;
        } else if (z1 == 0) {
            if (sum1 < minSum2) {
                return -1;
            } else {
                return sum1;
            }
        } else if (z2 == 0) {
            if (sum2 < minSum1) {
                return -1;
            } else {
                return sum2;
            }
        } else {
            return Math.Max(minSum1, minSum2);
        }
    }
    
    private void GetSumAndZeroCount(int[] nums, out long sum, out int zeroCount) {
        sum = 0;
        zeroCount = 0;
        foreach (var num in nums) {
            if (num == 0) {
                zeroCount++;
            } else {
                sum += num;
            }
        }
    }
}
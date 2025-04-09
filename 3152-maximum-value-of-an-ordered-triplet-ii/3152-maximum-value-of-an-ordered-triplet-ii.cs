public class Solution {
    public long MaximumTripletValue(int[] nums) {
        int n = nums.Length;

        int maxLeft = nums[0];
        long maxVal = 0;

        int[] MaxRights = new int[n - 2]; 
        MaxRights[n-3] = nums[n-1]; // Initializing the last valid index

        // Compute maxRight values in a backward pass
        for (int k = n - 2; k > 1; k--) {
            MaxRights[k - 2] = Math.Max(MaxRights[k - 1], nums[k]);
        }

        // Compute the max triplet value
        for (int j = 1; j < n - 1; j++) {
            maxVal = Math.Max(maxVal, (long)(maxLeft - nums[j]) * MaxRights[j - 1]);
            maxLeft = Math.Max(maxLeft, nums[j]);
        }

        return maxVal;
    }
}

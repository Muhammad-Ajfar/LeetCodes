public class Solution {
    public int CountSubarrays(int[] nums) {
        int n = nums.Length;
        int count = 0;
        for(int i = 1; i<n-1; i++)
        {
            if((nums[i-1] + nums[i+1])*2 == nums[i])
            {
                count++;
            }
        }
        return count;
    }
}
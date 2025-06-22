public class Solution {
    public int PartitionArray(int[] nums, int k) {
        Array.Sort(nums);
        int curMin = nums[0];
        int res = 1;

        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] - curMin > k)
            {
                res++;
                curMin = nums[i];
            }
        }

        return res;
    }
}
public class Solution {
    public int CountPairs(int[] nums, int k) {
        int count = 0;
        int n = nums.Length;

        for(int i = 0; i < n -1; i++)
        {
            for(int j = i+1; j < n; j++)
            {
                if((i * j) % k == 0 && nums[i] == nums[j])
                {
                    count++;
                }
            }
        }

        return count;
    }
}
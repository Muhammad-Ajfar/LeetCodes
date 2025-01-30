public class Solution {
    public void MoveZeroes(int[] nums) {
        int count = 0;
        for(int i = 0; i < nums.Length ; i++)
        {
            if(nums[i] == 0) count++;
            else
            {
                nums[i-count] = nums[i];
                if(count > 0)nums[i] = 0;
            }
        }
    }
}
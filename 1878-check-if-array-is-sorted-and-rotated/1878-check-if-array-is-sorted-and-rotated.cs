public class Solution {
    public bool Check(int[] nums) {
        int dropCount = 0;
        int n = nums.Length;

        for (int i = 0; i < n - 1; i++)
        {
            if (nums[i] > nums[i + 1])
            {
                dropCount++;
            }
        }

        // Check if the array can be rotated back to a sorted state
        if (dropCount == 0)
        {
            // Already sorted
            return true;
        }
        else if (dropCount == 1 && nums[n - 1] <= nums[0])
        {
            // Can be rotated to a sorted state
            return true;
        }
        else
        {
            // More than one drop or invalid rotation
            return false;
        }
    }
}   
public class Solution
{
    public int MaxProduct(int[] nums)
    {
        int max = Math.Max(nums[0], nums[1]);
        int secondMax = Math.Min(nums[0], nums[1]);

        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                secondMax = max;
                max = nums[i];
            }
            else if (nums[i] > secondMax) secondMax = nums[i];
        }

        return (max - 1) * (secondMax - 1);
    }
}
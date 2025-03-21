public class Solution {
    public int MaximumCount(int[] nums) {
        int neg = 0;
        int nonPos = 0;
        foreach(int num in nums)
        {
            if(num < 0)
            {
                neg++;
            }
            else if(num > 0)
            {
                break;

            }
            nonPos++;

        }

        return Math.Max(neg, nums.Length - nonPos);
    }
}
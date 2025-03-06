public class Solution {
    public int MaxSubArray(int[] nums) {
        int max = int.MinValue;
        int current = 0;
        foreach(int num in nums)
        {
            current += num;
            max = Math.Max(max , current);

            if(current < 0) current = 0;
        }
        return max;
    }
}
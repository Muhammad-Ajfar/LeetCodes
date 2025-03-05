public class Solution {
    public int MaxAbsoluteSum(int[] nums) {
        int max = int.MinValue;
        int current = 0;
        foreach(int num in nums)
        {
            current += num;
            max = Math.Max(max , current);

            if(current < 0) current = 0;
        }

        int min = int.MaxValue;
        current = 0;
        foreach(int num in nums)
        {
            current += num;
            min = Math.Min(min , current);
            if(current > 0) current = 0;
        }

        return Math.Max(max , Math.Abs(min));

    }
}
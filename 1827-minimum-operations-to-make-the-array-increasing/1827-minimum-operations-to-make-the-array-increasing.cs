public class Solution
{
    public int MinOperations(int[] nums)
    {
        int cur = int.MinValue;
        int operations = 0;

        foreach (int num in nums)
        {
            if (num <= cur)
            {
                operations += (cur - num) + 1;
                cur = cur + 1;
            }
            else cur = num;
        }
        
        return operations;
    }
}
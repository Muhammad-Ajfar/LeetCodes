public class Solution
{
    public int RepeatedNTimes(int[] nums)
    {
        var seen = new HashSet<int>();
        
        foreach (var num in nums)
        {
            if (seen.Contains(num))
                return num; // Found the repeated element
            seen.Add(num);
        }
        
        return -1; // Should never reach here given problem constraints
    }
}

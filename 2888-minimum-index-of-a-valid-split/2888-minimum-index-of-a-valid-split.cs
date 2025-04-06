public class Solution
{
    public int MinimumIndex(IList<int> nums)
    {
        int n = nums.Count;

        // Step 1: Find the dominant element using Boyer-Moore Algorithm
        int mode = 0, count = 0;
        foreach (int num in nums)
        {
            if (count == 0)
                mode = num;
            count += (num == mode) ? 1 : -1;
        }

        // Step 2: Count total occurrences of the dominant element
        int totalCount = 0;
        foreach (int num in nums)
        {
            if (num == mode) totalCount++;
        }

        // Step 3: Find the minimum index to split
        int leftCount = 0;
        for (int i = 0; i < n - 1; i++)
        {
            if (nums[i] == mode) leftCount++;

            if (leftCount * 2 > (i + 1) &&
                    (totalCount - leftCount) * 2 > (n - i - 1))
            {
                return i;
            }
        }

        return -1;
    }
}

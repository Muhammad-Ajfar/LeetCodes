public class Solution
{
    public int MaxFrequencyElements(int[] nums)
    {
        int count = 0;
        int maxFreq = 0;
        int[] freq = new int[101];

        foreach (int num in nums)
        {
            freq[num]++;

            if (freq[num] > maxFreq)
            {
                maxFreq = freq[num];
                count = 1;
            }
            else if (freq[num] == maxFreq)
            {
                count++;
            }
        }

        return count * maxFreq;
    }
}
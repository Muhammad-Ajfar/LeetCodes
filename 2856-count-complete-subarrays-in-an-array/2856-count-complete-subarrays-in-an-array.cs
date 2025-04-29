public class Solution {
    public int CountCompleteSubarrays(int[] nums) {
        int n = nums.Length;
        int k = CountDistinctNumbers(nums);
        int[] freq = new int[2001];
        int res = 0;
        int distincts = 0;
        int left = 0;

        for (int right = 0; right < n; right++) {
            int num = nums[right];

            if (freq[num] == 0) distincts++;
            freq[num]++;

            while (distincts >= k) {
                res += n - right;
                int leftNum = nums[left];
                freq[leftNum]--;
                if(freq[leftNum] == 0) distincts--;
                left++;
            }
        }

        return res;
    }

    public static int CountDistinctNumbers(int[] nums)
    {
        bool[] seen = new bool[2001];
        int count = 0;

        foreach (int num in nums)
        {
            if (!seen[num])
            {
                seen[num] = true;
                count++;
            }
        }

        return count;
    }

}
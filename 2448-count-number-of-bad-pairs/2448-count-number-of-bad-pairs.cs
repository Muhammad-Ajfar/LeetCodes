public class Solution {
    public long CountBadPairs(int[] nums) {
        if (nums.Length < 2)
        {
            return 0;
        }

        Dictionary<int, int> Counter = new Dictionary<int, int>();
        long GoodPairs = 0;
        long AllPairs = (long)nums.Length * (nums.Length - 1) / 2;
        int index = 0;
        foreach (int num in nums)
        {
            int diff = num - index;
            if (Counter.TryGetValue(diff, out int count))
            {
                GoodPairs += count;
                Counter[diff] = count + 1;
            }
            else
            {
                Counter[diff] = 1;
            }
            index++;
        }

        return AllPairs - GoodPairs;
    }
}
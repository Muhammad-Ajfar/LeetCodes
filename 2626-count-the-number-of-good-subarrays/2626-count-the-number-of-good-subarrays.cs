public class Solution {
    public long CountGood(int[] nums, int k) {
        int n = nums.Length;
        Dictionary<int, int> freq = new Dictionary<int, int>();
        long res = 0;
        long pairs = 0;
        int left = 0;

        for (int right = 0; right < n; right++) {
            int num = nums[right];

            if (!freq.ContainsKey(num))
                freq[num] = 0;

            pairs += freq[num];
            freq[num]++;

            while (pairs >= k) {
                res += n - right;
                int leftNum = nums[left];
                freq[leftNum]--;
                pairs -= freq[leftNum];
                left++;
            }
        }

        return res;
    }
}

public class Solution {
    public long CountSubarrays(int[] nums, int k) {
        int max = nums.Max(),
            maxCount = 0,
            n = nums.Length,
            l = 0;
        long count = 0;

        for (int r = 0; r < n; r++) {
            if (nums[r] == max) maxCount++;

            while (maxCount >= k) {
                count += n - r;

                if (nums[l++] == max) maxCount--;
            }
        }

        return count;
    }
}

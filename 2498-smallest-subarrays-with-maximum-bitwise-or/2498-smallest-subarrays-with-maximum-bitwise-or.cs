public class Solution {
    public int[] SmallestSubarrays(int[] nums) {
        int n = nums.Length;
        int[] res = new int[n];
        int[] lastSeen = new int[32];

        for (int i = 0; i < 32; i++)
            lastSeen[i] = -1;

        for (int i = n - 1; i >= 0; i--) {
            for (int b = 0; b < 32; b++) {
                if (((nums[i] >> b) & 1) == 1)
                    lastSeen[b] = i;
            }

            int maxRight = i;
            for (int b = 0; b < 32; b++) {
                if (lastSeen[b] != -1)
                    maxRight = Math.Max(maxRight, lastSeen[b]);
            }

            res[i] = maxRight - i + 1;
        }

        return res;
    }
}
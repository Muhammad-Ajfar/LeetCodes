public class Solution {
    public int MinZeroArray(int[] nums, int[][] queries) {
        int n = nums.Length;
        int m = queries.Length;
        int[] diff = new int[n + 1];

        int left = 0, right = m + 1;

        bool Check(int k) {
            Array.Clear(diff, 0, diff.Length);

            for (int i = 0; i < k; i++) {
                int l = queries[i][0], r = queries[i][1], val = queries[i][2];
                diff[l] += val;
                if (r + 1 < n) {
                    diff[r + 1] -= val;
                }
            }

            int sum = 0;
            for (int i = 0; i < n; i++) {
                sum += diff[i];
                if (nums[i] > sum) {
                    return false;
                }
            }
            return true;
        }

        while (left < right) {
            int mid = (left + right) / 2;
            if (Check(mid)) {
                right = mid;
            } else {
                left = mid + 1;
            }
        }

        return left > m ? -1 : left;
    }
}

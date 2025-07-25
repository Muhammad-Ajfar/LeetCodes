public class Solution {
    public int MaxSum(int[] nums) {
        bool[] seen = new bool[101];
        int maxNeg = -101;
        int res = 0;

        foreach (int num in nums)
        {
            if (num < 0) maxNeg = Math.Max(maxNeg, num);
            else if (!seen[num])
            {
                res += num;
                seen[num] = true;
            }
        }

        // No non-negative numbers found (even 0 not found), return maxNeg
        if (res == 0 && !seen[0]) return maxNeg;

        return res;
    }
}
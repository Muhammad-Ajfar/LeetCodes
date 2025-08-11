public class Solution
{
    public int[] ProductQueries(int n, int[][] queries)
    {
        List<int> powers = new List<int>();
        while (n > 0)
        {
            int x = n & -n; // lowest set bit
            powers.Add(x);
            n -= x;
        }

        const int mod = 1_000_000_007;
        int[] ans = new int[queries.Length];

        for (int i = 0; i < queries.Length; i++)
        {
            int l = queries[i][0], r = queries[i][1];
            long x = 1;
            for (int j = l; j <= r; j++)
            {
                x = (x * powers[j]) % mod;
            }
            ans[i] = (int)x;
        }

        return ans;
    }
}
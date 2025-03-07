public class Solution
{
    public int LenLongestFibSubseq(int[] arr)
    {
        int n = arr.Length;
        Dictionary<int, int> indexMap = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            indexMap[arr[i]] = i;
        }

        int maxLen = 0;
        int[,] dp = new int[n, n];

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                int diff = arr[i] - arr[j];
                if (indexMap.ContainsKey(diff) && indexMap[diff] < j)
                {
                    dp[j, i] = dp[indexMap[diff], j] + 1;
                    maxLen = Math.Max(maxLen, dp[j, i]);
                }
                else
                {
                    dp[j, i] = 2;
                }
            }
        }

        return maxLen >= 3 ? maxLen : 0;
    }
}
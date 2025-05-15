public class Solution
{
    public int LengthAfterTransformations(string s, int t)
    {
        const int MOD = 1_000_000_007;

        long[] counts = new long[26];

        // Initialize frequency of each character
        foreach (char ch in s)
            counts[ch - 'a']++;

        for (int step = 0; step < t; step++)
        {
            long[] nextCounts = new long[26];

            for (int i = 0; i < 26; i++)
            {
                if (i == 25) // 'z'
                {
                    // 'z' → "ab"
                    nextCounts[0] = (nextCounts[0] + counts[25]) % MOD; // 'a'
                    nextCounts[1] = (nextCounts[1] + counts[25]) % MOD; // 'b'
                }
                else
                {
                    // other characters just move one forward
                    nextCounts[i + 1] = (nextCounts[i + 1] + counts[i]) % MOD;
                }
            }

            counts = nextCounts;
        }

        long result = 0;
        for (int i = 0; i < 26; i++)
            result = (result + counts[i]) % MOD;

        return (int)result;
    }
}

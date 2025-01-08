public class Solution {
    public int[] VowelStrings(string[] words, int[][] queries) {
        HashSet<char> set = new HashSet<char> {'a','e','i','o','u'};
        int[] prefix = new int[words.Length];
        int[] result = new int[queries.Length];
        int count = 0;

        // Build the prefix sum array
        for (int i = 0; i < words.Length; i++) {
            if (set.Contains(words[i][0]) && set.Contains(words[i][words[i].Length - 1])) {
                count++;
            }
            prefix[i] = count;
        }

        // Answer the queries
        for (int i = 0; i < queries.Length; i++) {
            int li = queries[i][0], ri = queries[i][1];
            result[i] = li > 0 ? prefix[ri] - prefix[li - 1] : prefix[ri];
        }

        return result;
    }
}

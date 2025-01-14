public class Solution {
    public int CountPrefixSuffixPairs(string[] words) {
        int count = 0;
        for (int j = words.Length - 1; j >= 0; j--) {
            for (int i = 0; i < j; i++) {
                if (IsPrefixAndSuffix(words[i], words[j])) {
                    count++;
                }
            }
        }
        return count;
    }

    private bool IsPrefixAndSuffix(string str1, string str2) {
        int len1 = str1.Length;
        int len2 = str2.Length;

        if (len1 > len2)
            return false;

        // Compare prefix
        for (int i = 0; i < len1; i++) {
            if (str1[i] != str2[i])
                return false;
        }

        // Compare suffix
        for (int i = 0; i < len1; i++) {
            if (str1[len1 - 1 - i] != str2[len2 - 1 - i])
                return false;
        }

        return true;
    }
}

public class Solution {
    public int PrefixCount(string[] words, string pref) {
        int res = 0;
        int len = pref.Length;
        foreach (string word in words) {
            if (word.Length >= len && word.StartsWith(pref)) {
                res++;
            }
        }
        return res;
    }
}

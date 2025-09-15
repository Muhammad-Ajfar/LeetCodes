public class Solution {
    public int CanBeTypedWords(string text, string brokenLetters) {
        var words = text.Split(' ');
        int res = words.Length;
        var brokenSet = new HashSet<char>(brokenLetters);

        foreach (var word in words) {
            foreach (char c in word) {
                if (brokenSet.Contains(c)) {
                    res--;
                    break;
                }
            }
        }

        return res;
    }
}
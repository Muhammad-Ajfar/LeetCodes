public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        int i = 0, j = 0;
        int m = 0, n = 0;
        
        while (i < word1.Length && j < word2.Length) {
            if (word1[i][m] != word2[j][n]) return false;
            m++;
            n++;
            
            if (m == word1[i].Length) {
                i++;
                m = 0;
            }
            
            if (n == word2[j].Length) {
                j++;
                n = 0;
            }
        }
        
        return i == word1.Length && j == word2.Length;
    }
}
public class Solution {
    public int MostWordsFound(string[] sentences) {
        int maxWords = 0;
        foreach (string sentence in sentences) {
            int wordCount = sentence.Split(' ').Length;
            if(wordCount > maxWords)
            {
                maxWords = wordCount;
            }
        }
        return maxWords;
    }
}

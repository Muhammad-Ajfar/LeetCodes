public class Solution {
    public string AnswerString(string word, int numFriends) {
        if (numFriends == 1) return word; // Edge case: no split possible

        List<(int start, int end)> segments = new();
        StringBuilder sb = new StringBuilder();
        int curMax = 0; // Initialize to smallest possible value

        // First, find all positions of the maximum character in the entire word
        for (int i = 0; i < word.Length; i++) {
            int curVal = word[i];
            if (curVal > curMax) {
                curMax = curVal;
                segments.Clear();
                segments.Add((i,i));
            } else if (curVal == curMax) {
                segments.Add((i,i));
            }
        }
        sb.Append((char)curMax);

        // Now, for each subsequent character, find the maximum possible next character
        while (true) {
            curMax = 0; // Reset to smallest possible value
            List<(int start, int end)> newSegments = new();

            foreach (var (start, end) in segments) {
                int nextIdx = end + 1;
                if (nextIdx >= word.Length || (word.Length - (end+1 - start) < numFriends)) continue; // No more characters to add

                int curVal = word[nextIdx];
                if (curVal > curMax) {
                    curMax = curVal;
                    newSegments.Clear();
                    newSegments.Add((start, nextIdx));
                } else if (curVal == curMax) {
                    newSegments.Add((start, nextIdx));
                }
            }

            if (newSegments.Count == 0) break; // No more characters to add

            sb.Append((char)curMax);
            segments = new List<(int start, int end)>(newSegments);
        }

        return sb.ToString();
    }
}
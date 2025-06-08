public class Solution {
    public string RobotWithString(string s) {
        int[] freq = new int[26];
        foreach (char c in s)
            freq[c - 'a']++;

        Stack<char> t = new Stack<char>();
        StringBuilder result = new StringBuilder();
        int minCharIndex = 0;

        foreach (char c in s) {
            t.Push(c);
            freq[c - 'a']--;

            // Update the smallest character still left in s
            while (minCharIndex < 26 && freq[minCharIndex] == 0)
                minCharIndex++;

            // While top of stack is <= smallest remaining character in s
            while (t.Count > 0 && (t.Peek() - 'a') <= minCharIndex) {
                result.Append(t.Pop());
            }
        }

        // Empty remaining stack
        while (t.Count > 0)
            result.Append(t.Pop());

        return result.ToString();
    }
}

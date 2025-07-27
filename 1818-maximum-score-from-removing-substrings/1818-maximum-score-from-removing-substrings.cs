public class Solution {
    public int MaximumGain(string s, int x, int y) {
        if (x > y) {
            return RemovePattern(s, 'a', 'b', x, y);
        } else {
            return RemovePattern(s, 'b', 'a', y, x);
        }
    }

    private int RemovePattern(string s, char first, char second, int firstScore, int secondScore) {
        Stack<char> stack = new Stack<char>();
        int total = 0;

        // Step 1: Remove higher-value pairs (first+second)
        foreach (char c in s) {
            if (stack.Count > 0 && stack.Peek() == first && c == second) {
                stack.Pop();
                total += firstScore;
            } else {
                stack.Push(c);
            }
        }

        // Step 2: Reconstruct remaining string
        char[] remaining = stack.Reverse().ToArray();
        stack.Clear();

        // Step 3: Remove lower-value pairs (second+first)
        foreach (char c in remaining) {
            if (stack.Count > 0 && stack.Peek() == second && c == first) {
                stack.Pop();
                total += secondScore;
            } else {
                stack.Push(c);
            }
        }

        return total;
    }
}
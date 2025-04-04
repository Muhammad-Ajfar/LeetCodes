public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> stack = new Stack<int>(); // Stack to store scores

        foreach (string operation in operations) {
            if (operation == "C") {
                if (stack.Count > 0) stack.Pop(); // Invalidate last score
            } else if (operation == "D") {
                if (stack.Count > 0) stack.Push(2 * stack.Peek()); // Double the last score
            } else if (operation == "+") {
                if (stack.Count > 1) {
                    int top = stack.Pop(); // Get last score
                    int newTop = top + stack.Peek(); // Sum of last two scores
                    stack.Push(top); // Restore last score
                    stack.Push(newTop); // Push the new score
                }
            } else {
                stack.Push(int.Parse(operation)); // Convert and push number
            }
        }

        int sum = 0;
        foreach (int score in stack) {
            sum += score;
        }

        return sum;
    }
}

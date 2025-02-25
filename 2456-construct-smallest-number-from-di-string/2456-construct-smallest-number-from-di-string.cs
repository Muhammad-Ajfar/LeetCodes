using System;
using System.Collections.Generic;

public class Solution {
    public string SmallestNumber(string pattern) {
        Stack<int> stack = new Stack<int>();
        string result = "";
        int num = 1;

        for (int i = 0; i <= pattern.Length; i++) {
            // Push the current digit onto the stack
            stack.Push(num++);

            if (i == pattern.Length || pattern[i] == 'I') {
                while (stack.Count > 0) {
                    result += stack.Pop();
                }
            }
        }

        return result;
    }
}
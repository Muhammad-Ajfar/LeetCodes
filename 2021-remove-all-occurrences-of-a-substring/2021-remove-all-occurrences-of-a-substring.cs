public class Solution {
    public string RemoveOccurrences(string s, string part) {
        StringBuilder stack = new StringBuilder();
        int pLen = part.Length;

        foreach (char c in s) {
            stack.Append(c);

            // Check if the last characters in stack match `part`
            if (stack.Length >= pLen && 
                stack.ToString(stack.Length - pLen, pLen) == part) 
            {
                // Efficiently remove the last `pLen` characters
                stack.Length -= pLen;
            }
        }

        return stack.ToString();
    }
}

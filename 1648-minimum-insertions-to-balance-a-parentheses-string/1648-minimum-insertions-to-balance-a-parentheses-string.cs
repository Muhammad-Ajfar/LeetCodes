public class Solution {
    public int MinInsertions(string s) {
        int open = 0;  // Track open '(' parentheses count
        int res = 0;   // Track insertions needed
        
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(') {
                open++;  // Count open '('
            } 
            else { // Handling ')'
                if (i + 1 < s.Length && s[i + 1] == ')') {
                    // Found "))", move pointer forward
                    i++;
                } else {
                    // Single ')' found, needs an extra ')'
                    res++; 
                }

                if (open > 0) {
                    open--;  // Match an existing '('
                } else {
                    res++;  // No '(' to match, so add '('
                }
            }
        }

        res += 2 * open;  // Each unmatched '(' requires 2 ')'
        return res;
    }
}

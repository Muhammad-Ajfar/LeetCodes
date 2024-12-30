public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        int n = s.Length;

        for (int i = 1; i <= n / 2; i++) {
            // Check if the current substring length divides the string length evenly
            if (n % i == 0) {
                string substring = s.Substring(0, i);
                int repeatCount = n / i;

                // Construct the repeated pattern
                string repeatedPattern = new StringBuilder(substring.Length * repeatCount)
                    .Insert(0, substring, repeatCount)
                    .ToString();

                if (repeatedPattern == s) {
                    return true;
                }
            }
        }

        return false;
    }
}

public class Solution {
    public int MyAtoi(string s) {
        int i = 0, sign = 1, n = s.Length;
        long num = 0;

        // Skip leading spaces
        while (i < n && s[i] == ' ') i++;

        // Check sign
        if (i < n && (s[i] == '+' || s[i] == '-')) {
            sign = s[i] == '-' ? -1 : 1;
            i++;
        }

        // Parse digits
        while (i < n) {
            if (s[i] < '0' || s[i] > '9') break;
            num = num * 10 + (s[i] - '0');

            // Handle overflow
            if (num * sign >= int.MaxValue) return int.MaxValue;
            if (num * sign <= int.MinValue) return int.MinValue;

            i++;
        }

        return (int)(num * sign);
    }
}
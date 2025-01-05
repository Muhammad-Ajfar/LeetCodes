public class Solution {
    public string ToHex(int num) {
        if (num == 0) {
            return "0";
        }
        // Convert to unsigned 32-bit representation for negative numbers
        long n = num;
        if (n < 0) {
            n = (long)Math.Pow(2, 32) + n;
        }

        // Hexadecimal digits
        char[] digits = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};
        StringBuilder sb = new StringBuilder();

        // Construct hexadecimal string
        while (n > 0) {
            sb.Append(digits[n % 16]);
            n /= 16;
        }

        // Reverse the result since digits are added in reverse order
        return ReverseString(sb.ToString());
    }

    // Helper function to reverse a string
    private string ReverseString(string s) {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

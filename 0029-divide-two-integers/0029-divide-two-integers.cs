public class Solution {
    public int Divide(int dividend, int divisor) {
        // Handle edge case for overflow
        if (dividend == int.MinValue && divisor == -1)
             return int.MaxValue;

        // Determine the sign of the result
        int sign = ((dividend < 0) ^ (divisor < 0)) ? -1 : 1;

        // Work with absolute values to simplify calculation
        long lDividend = Math.Abs((long)dividend);
        long lDivisor = Math.Abs((long)divisor);

        long quotient = 0;

        // Perform bit manipulation division
        while (lDividend >= lDivisor) {
            long temp = lDivisor, multiple = 1;
            while (lDividend >= (temp << 1)) {
                temp <<= 1;
                multiple <<= 1;
            }
            lDividend -= temp;
            quotient += multiple;
        }

        // Apply the sign to the result
        if(sign < 0)
        {quotient = -quotient;}
        

        // Clamp the result to the range of 32-bit integers
        return (int)Math.Max(int.MinValue, Math.Min(int.MaxValue, quotient));
    }
}

public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        // Check n > 0, n is a power of two, and only even bit positions are set
        return n > 0 && (n & (n - 1)) == 0 && (n & 0x55555555) != 0;
    }
}
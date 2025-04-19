public class Solution {
    private const int MOD = 1000000007;

    public int CountGoodNumbers(long n) {
        long evenIndex = (n + 1) / 2;  // 0-based even indices
        long oddIndex = n / 2;

        long evenComb = ModPow(5, evenIndex, MOD);
        long oddComb = ModPow(4, oddIndex, MOD);

        return (int)(evenComb * oddComb % MOD);
    }

    // Fast modular exponentiation
    private long ModPow(long baseVal, long exponent, int mod) {
        long result = 1;
        baseVal %= mod;

        while (exponent > 0) {
            if ((exponent & 1) == 1) {  // If exponent is odd
                result = result * baseVal % mod;
            }
            baseVal = baseVal * baseVal % mod;
            exponent >>= 1;
        }

        return result;
    }
}

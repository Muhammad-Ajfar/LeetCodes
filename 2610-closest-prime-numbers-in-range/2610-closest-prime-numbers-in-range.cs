public class Solution {
    public int[] ClosestPrimes(int left, int right) {
        int nRoot = (int)Math.Sqrt(right);
        bool[] IsNotPrime = new bool[right + 1];

        for (int i = 2; i <= nRoot; i++) {
            if (!IsNotPrime[i]) {
                for (int j = i * i; j <= right; j += i) {
                    IsNotPrime[j] = true;
                }
            }
        }

        int prev = -1;
        int[] res = { -1, -1 };
        int minDiff = int.MaxValue;

        for (int i = left; i <= right; i++) {
            if (i > 1 && !IsNotPrime[i]) {
                if (prev != -1) {
                    int currentDiff = i - prev;
                    if (currentDiff < minDiff || (currentDiff == minDiff && prev < res[0])) {
                        minDiff = currentDiff;
                        res[0] = prev;
                        res[1] = i;
                    }
                }
                prev = i;
            }
        }

        return res[0] == -1 ? new int[] { -1, -1 } : res;
    }
}
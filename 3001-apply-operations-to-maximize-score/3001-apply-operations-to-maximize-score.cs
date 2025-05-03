public class Solution {
    private const int MOD = 1_000_000_007;
    private static int[] primeScores;

    static Solution() {
        // Precompute prime scores for all numbers up to 1e5
        const int maxNum = 100000;
        primeScores = new int[maxNum + 1];
        for (int i = 2; i <= maxNum; i++) {
            if (primeScores[i] == 0) { // i is prime
                for (int j = i; j <= maxNum; j += i) {
                    primeScores[j]++;
                }
            }
        }
    }

    public int MaximumScore(IList<int> nums, int k) {
        int n = nums.Count;
        Console.WriteLine(n);
        int[] ps = new int[n];
        for (int i = 0; i < n; i++) {
            ps[i] = primeScores[nums[i]];
        }

        int[] left = new int[n];
        int[] right = new int[n];
        Array.Fill(left, -1);
        Array.Fill(right, n);

        // Monotonic stack to find next greater to the left
        int[] stack = new int[n];
        int top = -1;
        for (int i = 0; i < n; i++) {
            while (top >= 0 && ps[stack[top]] < ps[i]) {
                top--;
            }
            if (top >= 0) {
                left[i] = stack[top];
            }
            stack[++top] = i;
        }

        // Monotonic stack to find next greater to the right
        top = -1;
        for (int i = n - 1; i >= 0; i--) {
            while (top >= 0 && ps[stack[top]] <= ps[i]) {
                top--;
            }
            if (top >= 0) {
                right[i] = stack[top];
            }
            stack[++top] = i;
        }

        // Sort the numbers in descending order along with their counts
        var list = new List<(int num, long count)>();
        for (int i = 0; i < n; i++) {
            long cnt = (long)(i - left[i]) * (right[i] - i);
            list.Add((nums[i], cnt));
        }
        list.Sort((a, b) => b.num.CompareTo(a.num));  // Sorting by num in descending order

        long result = 1;

        // Process the sorted list and multiply the result
        foreach (var item in list) {
            if (k <= 0) break;

            // Find the number of times we can take the current number
            long take = Math.Min(item.count, k);

            // Multiply the result by the number raised to the power of how many times it can be used
            result = (result * Power(item.num, take, MOD)) % MOD;

            // Reduce k by the number of times we took this number
            k -= (int)take;
        }

        return (int)result;
    }

    private long Power(long x, long y, int mod) {
        long res = 1;
        x %= mod;
        while (y > 0) {
            if ((y & 1) == 1)
                res = (res * x) % mod;
            y >>= 1;
            x = (x * x) % mod;
        }
        return res;
    }
}
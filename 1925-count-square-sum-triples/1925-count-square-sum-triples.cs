public class Solution {
    public int CountTriples(int n) 
    {
        int count = 0;

        // Maximum m such that m^2 + (m-1)^2 <= n^2
        int limit = (int)Math.Sqrt(n);

        for (int m = 2; m <= limit; m++)
        {
            for (int k = 1; k < m; k++)
            {
                // m and k must be coprime and one odd, one even
                if (((m - k) % 2 == 1) && Gcd(m, k) == 1)
                {
                    int a = m * m - k * k;
                    int b = 2 * m * k;
                    int c = m * m + k * k;

                    if (c > n)
                        continue;

                    // Count multiples
                    int mul = 1;
                    while (mul * c <= n)
                    {
                        count += 2; // (a,b,c) and (b,a,c)
                        mul++;
                    }
                }
            }
        }

        return count;
    }

    private int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = a % b;
            a = b;
            b = temp;
        }
        return a;
    }
}

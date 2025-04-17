public class Solution {
    public int CountSymmetricIntegers(int low, int high) {
        int count = 0;
        for (int num = low; num <= high; num++) {
            if (IsSymmetric(num)) {
                count++;
            }
        }
        return count;
    }
    
    private bool IsSymmetric(int num) {
        string s = num.ToString();
        int n = s.Length;
        if (n % 2 != 0) {
            return false;
        }
        int half = n / 2;
        int sum1 = 0;
        int sum2 = 0;
        for (int i = 0; i < half; i++) {
            sum1 += s[i] - '0';
        }
        for (int i = half; i < n; i++) {
            sum2 += s[i] - '0';
        }
        return sum1 == sum2;
    }
}
public class Solution {
    public bool IsPowerOfFour(int n) {
        int a = n;
        while (a > 1) {
            if (a % 4 != 0) return false;
            a /= 4;
        }
        return a == 1;
    }
}

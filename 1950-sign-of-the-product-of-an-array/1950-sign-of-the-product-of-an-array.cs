public class Solution {
    public int ArraySign(int[] nums) {
        int sign = 1;
        foreach (int num in nums) {
            if (num == 0) {
                return 0;
            } else if (num < 0) {
                sign *= -1;
            }
        }
        return sign;
    }
}
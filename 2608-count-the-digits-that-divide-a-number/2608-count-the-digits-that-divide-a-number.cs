public class Solution {
    public int CountDigits(int num) {
        int original = num, digit, count = 0;

        while (num > 0) {
            digit = num % 10;
            num /= 10;

            if (original % digit == 0) {
                count++;
            }
        }

        return count;
    }
}

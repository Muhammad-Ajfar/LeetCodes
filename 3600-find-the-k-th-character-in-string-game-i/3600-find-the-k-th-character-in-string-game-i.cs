public class Solution {
    public char KthCharacter(int k) {
        if (k == 1) {
            return 'a';
        }
        int length = 1;
        int operations = 0;
        while (length < k) {
            length *= 2;
            operations++;
        }
        int pos = k;
        int shift = 0;
        while (operations > 0) {
            int half = length / 2;
            if (pos > half) {
                pos -= half;
                shift++;
            }
            length = half;
            operations--;
        }
        return (char)('a' + (shift % 26));
    }
}
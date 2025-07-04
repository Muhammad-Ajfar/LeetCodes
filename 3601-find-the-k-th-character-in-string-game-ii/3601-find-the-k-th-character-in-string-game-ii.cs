using System;

public class Solution {
    public char KthCharacter(long k, int[] operations) {
        if (k == 1) {
            return 'a';
        }
        long len = 1;
        long newK = -1;
        int operation = -1;
        foreach (int ope in operations) {
            len *= 2;
            if (len >= k) {
                operation = ope;
                newK = k - len / 2;
                break;
            }
        }
        char ch = KthCharacter(newK, operations);
        if (operation == 0) {
            return ch;
        }
        return ch == 'z' ? 'a' : (char)(ch + 1);
    }
}
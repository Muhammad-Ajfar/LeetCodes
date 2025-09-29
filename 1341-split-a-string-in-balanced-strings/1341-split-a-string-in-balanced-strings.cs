public class Solution {
    public int BalancedStringSplit(string s) {
        int balance = 0, res = 0;

        foreach (char c in s) {
            if (c == 'R') balance++;
            else balance--;

            if (balance == 0) {
                res++;
            }
        }

        return res;
    }
}
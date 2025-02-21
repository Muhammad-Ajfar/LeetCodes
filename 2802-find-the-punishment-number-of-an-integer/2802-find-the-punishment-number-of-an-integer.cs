public class Solution {
    public int PunishmentNumber(int n) {
        int[] validNumbers = { 1, 9, 10, 36, 45, 55, 82, 91, 99, 100, 235, 297,
                        369, 370, 379, 414, 657, 675, 703, 756, 792, 909, 918,
                        945, 964, 990, 991, 999, 1000 };
        int i = 0;
        int res = 0;
        while (i < validNumbers.Length && validNumbers[i] <= n)
        {
            res += validNumbers[i] * validNumbers[i];
            i++;
        }
        return res;

    }
}
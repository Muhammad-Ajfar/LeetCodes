public class Solution {
    public int TotalMoney(int n) {
        int fullWeeks = n / 7;
        int extraDays = n % 7;

        int total =
            28 * fullWeeks +                     // Base value for all complete weeks
            7 * fullWeeks * (fullWeeks - 1) / 2 + // Increment per week (arithmetic series)
            extraDays * (fullWeeks + 1) +         // Base amount for extra days
            extraDays * (extraDays - 1) / 2;      // Increment within the partial week

        return total;
    }
}
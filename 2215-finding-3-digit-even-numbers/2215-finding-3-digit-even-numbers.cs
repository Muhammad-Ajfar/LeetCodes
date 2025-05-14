public class Solution {
    public int[] FindEvenNumbers(int[] digits) {
        int[] digitCounts = new int[10];
        foreach (int d in digits)
            digitCounts[d]++;

        var result = new List<int>();

        for (int num = 100; num <= 999; num += 2) { // only even numbers
            int a = num / 100;
            int b = (num / 10) % 10;
            int c = num % 10;

            int[] needed = new int[10];
            needed[a]++;
            needed[b]++;
            needed[c]++;

            bool canForm = true;
            for (int i = 0; i < 10; i++) {
                if (needed[i] > digitCounts[i]) {
                    canForm = false;
                    break;
                }
            }

            if (canForm)
                result.Add(num);
        }

        return result.ToArray();
    }
}

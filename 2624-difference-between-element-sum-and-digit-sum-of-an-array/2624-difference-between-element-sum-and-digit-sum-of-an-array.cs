public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int eSum = 0;
        int dSum = 0;

        foreach(int n in nums)
        {
            eSum += n;

            int num = n; // because n is used in loop.
            while(num > 0)
            {
                dSum += num % 10;
                num /= 10;
            }
        }

        return Math.Abs(eSum - dSum);
    }
}

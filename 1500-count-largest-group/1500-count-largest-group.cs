public class Solution {
    public int CountLargestGroup(int n) {
        int[] sumCounts = new int[37]; // Max sum is 36 (for 9999)
        
        for (int i = 1; i <= n; i++) {
            int sum = SumOfDigits(i);
            sumCounts[sum]++;
        }
        
        int maxSize = 0;
        int count = 0;
        for (int i = 1; i < sumCounts.Length; i++) {
            if (sumCounts[i] > maxSize) {
                maxSize = sumCounts[i];
                count = 1;
            } else if (sumCounts[i] == maxSize) {
                count++;
            }
        }
        return count;
    }
    
    private int SumOfDigits(int num) {
        int sum = 0;
        while (num > 0) {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}
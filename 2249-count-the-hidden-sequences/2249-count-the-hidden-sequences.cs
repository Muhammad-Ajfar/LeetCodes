public class Solution {
    public int NumberOfArrays(int[] differences, int lower, int upper) {
        long minSum = 0, maxSum = 0, curr = 0;
        foreach (int diff in differences) {
            curr += diff;
            if (curr < minSum) minSum = curr;
            if (curr > maxSum) maxSum = curr;
        }
        
        long left  = (long)lower - minSum;
        long right = (long)upper - maxSum;
        long count = right - left + 1;
        
        return count > 0 ? (int)count : 0;
    }
}

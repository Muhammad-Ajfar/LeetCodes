public class Solution {
    public int DifferenceOfSums(int n, int m) {
        int totalSum = n * (n + 1) / 2;
        int k = n / m;
        int num2 = m * k * (k + 1) / 2;
        int num1 = totalSum - num2;
        return num1 - num2;
    }
}
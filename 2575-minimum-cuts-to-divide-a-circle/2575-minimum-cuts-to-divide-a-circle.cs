public class Solution {
    public int NumberOfCuts(int n) {
        return n % 2 == 0 || n == 1 ? n / 2 : n;
    }
}
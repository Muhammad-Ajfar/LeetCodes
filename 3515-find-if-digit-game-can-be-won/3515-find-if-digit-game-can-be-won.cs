public class Solution {
    public bool CanAliceWin(int[] nums) {
        int sumSingle = 0;
        int sumDouble = 0;
        int totalSum = 0;
        
        foreach (int num in nums) {
            totalSum += num;
            if (num < 10) {
                sumSingle += num;
            } else {
                sumDouble += num;
            }
        }
        
        bool winSingle = sumSingle > (totalSum - sumSingle);
        bool winDouble = sumDouble > (totalSum - sumDouble);
        
        return winSingle || winDouble;
    }
}
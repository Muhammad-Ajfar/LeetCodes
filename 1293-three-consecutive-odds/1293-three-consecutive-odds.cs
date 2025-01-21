public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        int count = 0;

        foreach (int num in arr) {
            if (num % 2 == 1) { // Check if the number is odd
                count++;
                if (count == 3) {
                    return true;
                }
            } else {
                count = 0; // Reset count if the current number is not odd
            }
        }

        return false; // No three consecutive odd numbers found
    }
}

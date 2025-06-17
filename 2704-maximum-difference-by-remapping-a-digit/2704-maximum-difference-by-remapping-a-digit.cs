public class Solution {
    public int MinMaxDifference(int num) {
        if (num < 10) return 9; // Handle single-digit case
        
        // Find first digit and first non-nine digit
        int firstDigit = 0;
        int nonNineDigit = 9;
        int temp = num;
        int divisor = 1;
        
        // Find the highest place value
        while (temp / divisor >= 10) {
            divisor *= 10;
        }
        
        // Scan digits from left to right
        while (divisor > 0) {
            int digit = (num / divisor) % 10;
            
            if (firstDigit == 0) {
                firstDigit = digit; // Set first digit
            }
            
            if (digit != 9 && nonNineDigit == 9) {
                nonNineDigit = digit; // Set first non-nine digit
            }
            
            divisor /= 10;
        }
        
        // Calculate min and max
        int min = ReplaceDigit(num, firstDigit, 0);
        int max = nonNineDigit == 9 ? num : ReplaceDigit(num, nonNineDigit, 9);
        
        return max - min;
    }
    
    private int ReplaceDigit(int number, int digitToReplace, int replacementDigit) {
        int result = 0;
        int place = 1;
        
        while (number > 0) {
            int digit = number % 10;
            digit = (digit == digitToReplace) ? replacementDigit : digit;
            result += digit * place;
            place *= 10;
            number /= 10;
        }
        
        return result;
    }
}
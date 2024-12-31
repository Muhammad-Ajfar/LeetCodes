using System.Collections.Generic;

public class Solution {
    public bool IsHappy(int n) {
        switch(n)
        {
            case 1 : return true;
                     break;
            case 2 : return false;
                     break;
            case 3 : return false;
                     break;
            case 4 : return false;
                     break;
            case 5 : return false;
                     break;
            case 6 : return false;
                     break;
            case 7 : return true;
                     break;
            case 8 : return false;
                     break;
            case 9 : return false;
                     break;
        }    
        n = GetSumOfSquares(n);
        return IsHappy(n);
    }

    private int GetSumOfSquares(int n) {
        int sum = 0;

        while (n > 0) {
            int digit = n % 10;
            sum += digit * digit; // Add square of the digit.
            n /= 10; // Remove the last digit.
        }

        return sum;
    }
}

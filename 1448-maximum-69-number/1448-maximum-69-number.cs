public class Solution {
    public int Maximum69Number (int num) {
        int val = 0;
        int place = 1;
        int temp = num;

        while (temp > 0) {
            if (temp % 10 == 6) val = place;
            
            temp /= 10;
            place *= 10;
        }

        return num + 3 * val;
    }
}
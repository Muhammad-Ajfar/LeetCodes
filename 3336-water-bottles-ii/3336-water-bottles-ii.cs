public class Solution {
    public int MaxBottlesDrunk(int numBottles, int numExchange) {
        int total = numBottles;
        int empty = numBottles;
        int full = 0;
        
        while (full > 0 || empty >= numExchange) {
            if (full > 0) {
                total++;
                full--;
                empty++;
            } else if (empty >= numExchange) {
                empty -= numExchange;
                full++;
                numExchange++;
            }
        }
        
        return total;
    }
}
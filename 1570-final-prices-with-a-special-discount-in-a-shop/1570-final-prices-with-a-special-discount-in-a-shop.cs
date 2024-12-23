public class Solution {
    public int[] FinalPrices(int[] prices) {
        Stack<int> stack = new Stack<int>();
        
        for (int i = 0; i < prices.Length; i++) {
            // Find the next smaller or equal price
            while (stack.Count > 0 && prices[stack.Peek()] >= prices[i]) {
                int index = stack.Pop();
                prices[index] -= prices[i];
            }
            // Push the current index onto the stack
            stack.Push(i);
        }
        
        return prices;
    }
}

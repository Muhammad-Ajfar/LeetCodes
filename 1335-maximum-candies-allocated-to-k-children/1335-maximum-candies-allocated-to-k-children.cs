public class Solution {
    public int MaximumCandies(int[] candies, long k) {
        int low = 1;
        int high = candies.Max();
        int res = 0;
        while (low <= high) {
            int mid = low + (high - low) / 2;
            long piles = 0;
            
            foreach (int num in candies) {
                piles += num / mid;
            }

            if (piles >= k) {
                res = mid;
                low = mid + 1;
            } else {
                high = mid - 1;
            }
        }
        return res;
    }
}

public class Solution {
    public int MinCapability(int[] nums, int k) {
        int low = nums.Min(), high = nums.Max();
        
        while (low < high) {
            int mid = low + (high - low) / 2;
            int houses = 0;

            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] <= mid) {
                    houses++;
                    i++;
                }
            }

            if (houses >= k) {
                high = mid;
            } else {
                low = mid + 1;
            }
        }

        return low;
    }
}

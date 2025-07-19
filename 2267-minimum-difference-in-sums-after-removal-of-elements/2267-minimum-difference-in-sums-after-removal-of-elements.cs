public class Solution {
    public long MinimumDifference(int[] nums) {
        int len = nums.Length;
        int n = len / 3;

        // Left prefix sum using max heap (simulate n smallest)
        long[] leftSum = new long[n + 1];
        var maxHeap = new PriorityQueue<int, int>();
        long sum = 0;

        for (int i = 0; i < n; i++) {
            maxHeap.Enqueue(nums[i], -nums[i]);
            sum += nums[i];
        }

        leftSum[0] = sum;

        for (int i = n; i < 2 * n; i++) {
            sum += nums[i];
            maxHeap.Enqueue(nums[i], -nums[i]);
            int removed = maxHeap.Dequeue();
            sum -= removed;
            leftSum[i - n + 1] = sum;
        }

        // Right suffix sum using min heap (simulate n largest)
        long[] rightSum = new long[n + 1];
        var minHeap = new PriorityQueue<int, int>();
        sum = 0;

        for (int i = len - 1; i >= 2 * n; i--) {
            minHeap.Enqueue(nums[i], nums[i]);
            sum += nums[i];
        }

        rightSum[n] = sum;

        for (int i = 2 * n - 1; i >= n; i--) {
            sum += nums[i];
            minHeap.Enqueue(nums[i], nums[i]);
            int removed = minHeap.Dequeue();
            sum -= removed;
            rightSum[i - n] = sum;
        }

        // Compute minimum difference
        long result = long.MaxValue;
        for (int i = 0; i <= n; i++) {
            result = Math.Min(result, leftSum[i] - rightSum[i]);
        }

        return result;
    }
}
public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
        var pq = new PriorityQueue<int, (int value, int index)>();

        // Initialize the priority queue with indices and corresponding values
        for (int i = 0; i < nums.Length; i++) {
            pq.Enqueue(i, (nums[i], i));
        }

        // Perform k operations
        while (k-- > 0) {
            int index = pq.Dequeue();
            nums[index] *= multiplier;
            pq.Enqueue(index, (nums[index], index));
        }

        return nums;
    }
}

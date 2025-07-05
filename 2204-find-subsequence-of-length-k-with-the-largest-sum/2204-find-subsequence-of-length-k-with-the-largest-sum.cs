public class Solution {
    public int[] MaxSubsequence(int[] nums, int k) {
        // Use a min-heap with negated priorities to simulate a max-heap
        var minHeap = new PriorityQueue<(int num, int index), int>();
        
        for (int i = 0; i < nums.Length; i++) {
            // Store the original num and index, but use -num as the priority
            minHeap.Enqueue((nums[i], i), -nums[i]);
        }
        
        var topK = new List<(int num, int index)>();
        for (int i = 0; i < k; i++) {
            topK.Add(minHeap.Dequeue());
        }
        
        // Sort the top k elements by their original index
        topK.Sort((a, b) => a.index.CompareTo(b.index));
        
        int[] result = topK.Select(x => x.num).ToArray();
        
        return result;
    }
}
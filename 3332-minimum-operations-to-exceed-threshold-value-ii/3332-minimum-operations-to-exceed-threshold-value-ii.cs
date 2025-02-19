using System.Collections.Generic;

public class Solution {
    public int MinOperations(int[] nums, int k) {
        PriorityQueue<long, long> pq = new PriorityQueue<long, long>();

        // Populate priority queue (Min-Heap)
        foreach (int num in nums) {
            pq.Enqueue(num, num);
        }

        int operations = 0;

        // Process until the smallest element is at least k
        while (pq.Peek() < k) {
            long min1 = pq.Dequeue();
            long min2 = pq.Dequeue();

            // Merge the two smallest elements
            long newVal = min1 * 2 + min2;
            pq.Enqueue(newVal, newVal);
            operations++;
        }

        return operations;
    }
}

using System;
using System.Collections.Generic;

public class Solution {
    public long FindScore(int[] nums) {
        long score = 0;
        int n = nums.Length;

        // Priority Queue for (value, index)
        PriorityQueue<(int value, int index), (int,int)> pq = new PriorityQueue<(int value, int index), (int,int)>();

        // Add all elements to the priority queue
        for (int i = 0; i < n; i++) {
            pq.Enqueue((nums[i], i), (nums[i],i));
        }

        // Boolean array to keep track of marked elements
        bool[] marked = new bool[n]; 

        // Process elements in the priority queue
        while (pq.Count > 0) {
            var (minVal, index) = pq.Dequeue();

            // Skip if already marked
            if (marked[index]) continue;

            // Add the value to the score
            score += minVal;

            // Mark the current index
            marked[index] = true;

            // Mark neighbors
            if (index - 1 >= 0) marked[index - 1] = true;
            if (index + 1 < n) marked[index + 1] = true;
        }

        return score;
    }
}

public class Solution {
    public int MaxEvents(int[][] events) {
        // Sort events by start day
        Array.Sort(events, (a, b) => a[0] - b[0]);
        
        var minHeap = new PriorityQueue<int, int>();
        int maxEvents = 0;
        int i = 0;
        int n = events.Length;
        
        for (int day = 1; day <= 100000; day++) {
            // Add all events that start today
            while (i < n && events[i][0] == day) {
                minHeap.Enqueue(events[i][1], events[i][1]);
                i++;
            }
            
            // Remove expired events (endDay < day)
            while (minHeap.Count > 0 && minHeap.Peek() < day) {
                minHeap.Dequeue();
            }
            
            // Attend the earliest-ending event
            if (minHeap.Count > 0) {
                minHeap.Dequeue();
                maxEvents++;
            }
        }
        
        return maxEvents;
    }
}
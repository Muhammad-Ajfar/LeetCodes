public class Solution {
    public int MaxCandies(int[] status, int[] candies, int[][] keys, int[][] containedBoxes, int[] initialBoxes) {
        int n = status.Length;
        bool[] isAvailable = new bool[n];
        bool[] visited = new bool[n];
        var queue = new Queue<int>();
        
        foreach (int box in initialBoxes) {
            isAvailable[box] = true;
            if (status[box] == 1) {
                queue.Enqueue(box);
                visited[box] = true;
            }
        }

        int count = 0;
        
        while (queue.Count > 0) {
            int cur = queue.Dequeue();
            count += candies[cur];

            foreach (int key in keys[cur]) {
                status[key] = 1;
                if (isAvailable[key] && !visited[key]) {
                    queue.Enqueue(key);
                    visited[key] = true;
                }
            }
            
            foreach (int box in containedBoxes[cur]) {
                isAvailable[box] = true;
                if (status[box] == 1 && !visited[box]) {
                    queue.Enqueue(box);
                    visited[box] = true;
                }
            }
        }

        return count;
    }
}
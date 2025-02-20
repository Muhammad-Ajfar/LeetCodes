public class Solution {
    public int MinOperations(int[] nums, int k) {
        var priorityQueue = new PriorityQueue<int, int>();

        foreach (var num in nums)
        {
            if (num < k)
            {
                priorityQueue.Enqueue(num, num);
            }
        }

        var res = 0;
        while (priorityQueue.Count > 1)
        {
            var x = priorityQueue.Dequeue();
            var y = priorityQueue.Dequeue();

            if (x * 2 < k - y)
            {
                priorityQueue.Enqueue(x * 2 + y, x * 2 + y);
            }

            res++;
        }

        return res + priorityQueue.Count;
    }
}
public class Solution {
    public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime) {
        int n = startTime.Length;
        if (n == 0) return eventTime;

        int sum = startTime[0], maxFree = sum;
        var q = new Queue<int>();
        q.Enqueue(sum);

        for (int i = 1; i < n; i++) {
            int gap = startTime[i] - endTime[i - 1];
            q.Enqueue(gap);
            sum += gap;

            if (q.Count > k + 1) sum -= q.Dequeue();
            maxFree = Math.Max(maxFree, sum);
        }

        int lastGap = eventTime - endTime[n - 1];
        q.Enqueue(lastGap);
        sum += lastGap;

        if (q.Count > k + 1) sum -= q.Dequeue();
        maxFree = Math.Max(maxFree, sum);

        return maxFree;
    }
}
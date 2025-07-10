public class Solution {
    public int MaxFreeTime(int eventTime, int[] startTime, int[] endTime) {
        int n = startTime.Length;
        bool[] canMove = new bool[n];

        int maxLeftGap = 0;
        for (int i = 0; i < n; i++) {
            int duration = endTime[i] - startTime[i];

            // If this meeting can fit into any previous gap
            if (duration <= maxLeftGap)
                canMove[i] = true;

            // Update max gap on the left of this meeting
            int gap = startTime[i] - (i == 0 ? 0 : endTime[i - 1]);
            maxLeftGap = Math.Max(maxLeftGap, gap);
        }

        int maxRightGap = 0;
        for (int i = n - 1; i >= 0; i--) {
            int duration = endTime[i] - startTime[i];

            // If this meeting can fit into any right-side gap
            if (duration <= maxRightGap)
                canMove[i] = true;

            // Update max gap on the right of this meeting
            int gap = (i == n - 1 ? eventTime : startTime[i + 1]) - endTime[i];
            maxRightGap = Math.Max(maxRightGap, gap);
        }

        int maxFreeTime = 0;
        for (int i = 0; i < n; i++) {
            int segmentStart = (i == 0) ? 0 : endTime[i - 1];
            int segmentEnd = (i == n - 1) ? eventTime : startTime[i + 1];

            if (canMove[i]) {
                // Entire segment becomes free
                maxFreeTime = Math.Max(maxFreeTime, segmentEnd - segmentStart);
            } else {
                // Only the part not blocked by the meeting is free
                int occupied = endTime[i] - startTime[i];
                maxFreeTime = Math.Max(maxFreeTime, segmentEnd - segmentStart - occupied);
            }
        }

        return maxFreeTime;
    }
}
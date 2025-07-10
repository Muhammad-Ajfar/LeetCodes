public class Solution {
    public int MaxFreeTime(int eventTime, int[] startTime, int[] endTime) {
        int n = startTime.Length;
        int[] gaps = new int[n + 1];

        // Fill gaps array
        gaps[0] = startTime[0];
        for (int i = 1; i < n; i++)
            gaps[i] = startTime[i] - endTime[i - 1];
        gaps[n] = eventTime - endTime[n - 1];

        Array.Sort(gaps); // ascending

        int maxFreeTime = 0;
        int rightGap = startTime[0];

        for (int i = 0; i < n; i++) {
            int leftGap = rightGap;
            rightGap = (i < n - 1) ? startTime[i + 1] - endTime[i] : eventTime - endTime[i];

            int duration = endTime[i] - startTime[i];
            int freeTime = leftGap + rightGap;

            int skipLeft = 1, skipRight = 1;

            for (int j = gaps.Length - 1; j >= 0; j--) {
                int gap = gaps[j];
                if (gap < duration) break;
                if (gap == leftGap && skipLeft-- > 0) continue;
                if (gap == rightGap && skipRight-- > 0) continue;

                freeTime += duration;
                break;
            }

            maxFreeTime = Math.Max(maxFreeTime, freeTime);
        }

        return maxFreeTime;
    }
}
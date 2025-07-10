public class Solution {
    public int MaxFreeTime(int eventTime, int[] startTime, int[] endTime) {
        int n = startTime.Length;
        int[] gaps = new int[n + 1];

        // Build gap array
        gaps[0] = startTime[0];
        for (int i = 1; i < n; i++)
            gaps[i] = startTime[i] - endTime[i - 1];
        gaps[n] = eventTime - endTime[n - 1];

        // Sort ascending, will traverse from end
        Array.Sort(gaps);

        int maxFreeTime = 0;

        for (int i = 0; i < n; i++) {
            int duration = endTime[i] - startTime[i];
            int leftGap = (i == 0) ? startTime[0] : startTime[i] - endTime[i - 1];
            int rightGap = (i == n - 1) ? eventTime - endTime[i] : startTime[i + 1] - endTime[i];

            int freeTime = leftGap + rightGap;
            int leftUsed = 0, rightUsed = 0;

            for (int j = gaps.Length - 1; j >= 0; j--) {
                int gap = gaps[j];
                if (gap < duration) break;

                if (gap == leftGap && leftUsed == 0) {
                    leftUsed = 1;
                    continue;
                }

                if (gap == rightGap && rightUsed == 0) {
                    rightUsed = 1;
                    continue;
                }

                freeTime += duration;
                break;
            }

            maxFreeTime = Math.Max(maxFreeTime, freeTime);
        }

        return maxFreeTime;
    }
}

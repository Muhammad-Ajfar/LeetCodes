public class Solution {
    public int MostBooked(int n, int[][] meetings) {
        Array.Sort(meetings, (a, b) => a[0].CompareTo(b[0]));

        int[] meetingCount = new int[n];

        var available = new SortedSet<int>();
        for (int i = 0; i < n; i++) available.Add(i);

        var busy = new SortedSet<(long, int)>(Comparer<(long, int)>.Create(
            (a, b) => a.Item1 != b.Item1 ? a.Item1.CompareTo(b.Item1) : a.Item2.CompareTo(b.Item2)
        ));

        foreach (var meeting in meetings) {
            long start = meeting[0], end = meeting[1], duration = end - start;

            while (busy.Count > 0 && busy.Min.Item1 <= start) {
                int room = busy.Min.Item2;
                busy.Remove(busy.Min);
                available.Add(room);
            }

            if (available.Count > 0) {
                int room = available.Min;
                available.Remove(room);
                meetingCount[room]++;
                busy.Add((start + duration, room));
            } else {
                var earliest = busy.Min;
                busy.Remove(earliest);
                long nextFreeTime = earliest.Item1;
                int room = earliest.Item2;
                meetingCount[room]++;
                busy.Add((nextFreeTime + duration, room));
            }
        }

        int maxRoom = 0;
        for (int i = 1; i < n; i++) {
            if (meetingCount[i] > meetingCount[maxRoom])
                maxRoom = i;
        }

        return maxRoom;
    }
}
public class Solution
{
    public int ClosestMeetingNode(int[] edges, int node1, int node2)
    {
        int n = edges.Length;

        int[] dist1 = GetDistances(edges, node1, n);
        int[] dist2 = GetDistances(edges, node2, n);

        int result = -1;
        int minDist = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            if (dist1[i] != -1 && dist2[i] != -1)
            {
                int maxDist = Math.Max(dist1[i], dist2[i]);
                if (maxDist < minDist)
                {
                    minDist = maxDist;
                    result = i;
                }
            }
        }

        return result;
    }

    private int[] GetDistances(int[] edges, int start, int n)
    {
        int[] dist = new int[n];
        Array.Fill(dist, -1);
        bool[] visited = new bool[n];

        int curr = start;
        int d = 0;

        while (curr != -1 && !visited[curr])
        {
            dist[curr] = d++;
            visited[curr] = true;
            curr = edges[curr];
        }

        return dist;
    }
}

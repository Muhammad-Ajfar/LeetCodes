public class Solution {
    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2, int k) {
        int n = edges1.Length + 1;
        int m = edges2.Length + 1;

        // Build adjacency lists
        List<int>[] tree1 = BuildGraph(n, edges1);
        List<int>[] tree2 = BuildGraph(m, edges2);

        // Precompute reachability counts
        int[] reach1 = new int[n];
        for (int i = 0; i < n; i++)
            reach1[i] = CountReach(tree1, i, k);

        int maxReach2 = 0;
        for (int i = 0; i < m; i++)
            maxReach2 = Math.Max(maxReach2, CountReach(tree2, i, k - 1));

        int[] answer = new int[n];
        for (int i = 0; i < n; i++)
            answer[i] = reach1[i] + maxReach2;

        return answer;
    }

    List<int>[] BuildGraph(int size, int[][] edges) {
        var graph = new List<int>[size];
        for (int i = 0; i < size; i++) graph[i] = new List<int>();
        foreach (var edge in edges) {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }
        return graph;
    }

    int CountReach(List<int>[] graph, int start, int maxDist) {
        int count = 0;
        var visited = new bool[graph.Length];
        var queue = new Queue<(int node, int dist)>();
        queue.Enqueue((start, 0));
        visited[start] = true;

        while (queue.Count > 0) {
            var (u, d) = queue.Dequeue();
            if (d > maxDist) continue;
            count++;
            foreach (var v in graph[u]) {
                if (!visited[v]) {
                    visited[v] = true;
                    queue.Enqueue((v, d + 1));
                }
            }
        }

        return count;
    }
}

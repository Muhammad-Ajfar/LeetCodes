using System;
using System.Collections.Generic;

public class Solution
{
    private Dictionary<int, List<int>> graph = new();
    private int[] ts;
    private int ans = int.MinValue;

    public int MostProfitablePath(int[][] edges, int bob, int[] amount)
    {
        int n = edges.Length + 1;
        ts = new int[n];
        Array.Fill(ts, n);

        // Build the adjacency list
        foreach (var edge in edges)
        {
            if (!graph.ContainsKey(edge[0])) graph[edge[0]] = new List<int>();
            if (!graph.ContainsKey(edge[1])) graph[edge[1]] = new List<int>();

            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        // Step 1: Find Bob's arrival time at each node
        Dfs1(bob, -1, 0);
        ts[bob] = 0;

        // Step 2: Find the maximum profit Alice can make
        Dfs2(0, -1, 0, 0, amount);

        return ans;
    }

    // DFS to calculate Bob's arrival times
    private bool Dfs1(int node, int parent, int time)
    {
        if (node == 0)
        {
            ts[node] = Math.Min(ts[node], time);
            return true;
        }

        foreach (var neighbor in graph[node])
        {
            if (neighbor == parent) continue;
            if (Dfs1(neighbor, node, time + 1))
            {
                ts[neighbor] = Math.Min(ts[neighbor], time + 1);
                return true;
            }
        }

        return false;
    }

    // DFS to calculate Alice's maximum profit
    private void Dfs2(int node, int parent, int time, int profit, int[] amount)
    {
        if (time == ts[node]) profit += amount[node] / 2;
        else if (time < ts[node]) profit += amount[node];

        // If it's a leaf node (only parent exists)
        if (graph[node].Count == 1 && graph[node][0] == parent)
        {
            ans = Math.Max(ans, profit);
            return;
        }

        foreach (var neighbor in graph[node])
        {
            if (neighbor != parent)
                Dfs2(neighbor, node, time + 1, profit, amount);
        }
    }
}

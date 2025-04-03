public class Solution {
    public int[] MinimumCost(int n, int[][] edges, int[][] query) {
        // DSU Arrays
        int[] parent = new int[n];
        int[] rank = new int[n];
        int[] andValue = new int[n];

        // Initialize DSU
        for (int i = 0; i < n; i++) {
            parent[i] = i;
            rank[i] = 1;
            andValue[i] = int.MaxValue; // Start with all bits set (111111...)
        }

        // Find function with path compression
        int Find(int node) {
            if (parent[node] != node) {
                parent[node] = Find(parent[node]); // Path Compression
            }
            return parent[node];
        }

        // Union function with rank optimization
        void Union(int u, int v, int weight) {
            int rootU = Find(u);
            int rootV = Find(v);

            if (rootU != rootV) {
                if (rank[rootU] > rank[rootV]) {
                    parent[rootV] = rootU;
                    andValue[rootU] &= andValue[rootV] & weight; // Update AND value
                } else if (rank[rootU] < rank[rootV]) {
                    parent[rootU] = rootV;
                    andValue[rootV] &= andValue[rootU] & weight; // Update AND value
                } else {
                    parent[rootV] = rootU;
                    rank[rootU]++;
                    andValue[rootU] &= andValue[rootV] & weight; // Update AND value
                }
            } else {
                // If already connected, update the AND value of the root
                andValue[rootU] &= weight;
            }
        }

        // Build DSU with edges
        foreach (var edge in edges) {
            int u = edge[0], v = edge[1], w = edge[2];
            Union(u, v, w);
        }

        // Process queries
        int[] result = new int[query.Length];
        for (int i = 0; i < query.Length; i++) {
            int s = query[i][0], t = query[i][1];
            if (Find(s) != Find(t)) {
                result[i] = -1; // No connection
            } else {
                result[i] = andValue[Find(s)]; // Get precomputed AND value
            }
        }

        return result;
    }
}
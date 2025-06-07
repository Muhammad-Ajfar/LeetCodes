public class Solution {
    public string SmallestEquivalentString(string s1, string s2, string baseStr) {
        DSU dsu = new DSU(26); // 26 letters in the alphabet
        
        // Union equivalent characters
        for (int i = 0; i < s1.Length; i++) {
            int c1 = s1[i] - 'a';
            int c2 = s2[i] - 'a';
            dsu.Union(c1, c2);
        }
        
        // Build the result string
        char[] result = new char[baseStr.Length];
        for (int i = 0; i < baseStr.Length; i++) {
            int c = baseStr[i] - 'a';
            int root = dsu.Find(c);
            // The smallest character in the group is the root
            result[i] = (char)(root + 'a');
        }
        
        return new string(result);
    }
}

// Modified DSU that keeps track of the smallest character in each set
public class DSU {
    private int[] parent;
    
    public DSU(int size) {
        parent = new int[size];
        for (int i = 0; i < size; i++) {
            parent[i] = i; // Each character is its own parent initially
        }
    }
    
    public int Find(int x) {
        if (parent[x] != x) {
            parent[x] = Find(parent[x]); // Path compression
        }
        return parent[x];
    }
    
    public void Union(int x, int y) {
        int xRoot = Find(x);
        int yRoot = Find(y);
        
        if (xRoot == yRoot) return;
        
        // Union by smallest character - make the smaller root the parent
        if (xRoot < yRoot) {
            parent[yRoot] = xRoot;
        } else {
            parent[xRoot] = yRoot;
        }
    }
}
public class Solution {
    public IList<int> LexicalOrder(int n) {
        var res = new List<int>(n);
        for (int i = 1; i <= 9; i++) {
            DFS(i, n, res);
        }
        return res;
    }

    private void DFS(int current, int limit, List<int> list) {
        if (current > limit) return;
        list.Add(current);
        for (int i = 0; i <= 9; i++) {
            int next = current * 10 + i;
            if (next > limit) return;
            DFS(next, limit, list);
        }
    }
}

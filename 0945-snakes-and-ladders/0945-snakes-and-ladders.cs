public class Solution {
    public int SnakesAndLadders(int[][] board) {
        int n = board.Length;
        int[] flatArray = new int[n * n + 1];
        int cell = 1;

        bool leftToRight = true;
        for (int row = n - 1; row >= 0; row--) {
            if (leftToRight) {
                for (int col = 0; col < n; col++) {
                    flatArray[cell++] = board[row][col];
                }
            } else {
                for (int col = n - 1; col >= 0; col--) {
                    flatArray[cell++] = board[row][col];
                }
            }
            leftToRight = !leftToRight;
        }

        return Bfs(flatArray);
    }

    private int Bfs(int[] flat) {
        int n2 = flat.Length - 1;
        bool[] seen = new bool[flat.Length];
        Queue<(int val, int steps)> queue = new Queue<(int, int)>();
        queue.Enqueue((1, 0));
        seen[1] = true;

        while (queue.Count > 0) {
            var (curr, steps) = queue.Dequeue();
            for (int move = 1; move <= 6 && curr + move <= n2; move++) {
                int next = curr + move;
                int dest = flat[next] != -1 ? flat[next] : next;

                if (dest == n2)
                    return steps + 1;

                if (!seen[dest]) {
                    seen[dest] = true;
                    queue.Enqueue((dest, steps + 1));
                }
            }
        }

        return -1;
    }
}

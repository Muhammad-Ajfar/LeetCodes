public class Solution {
    public string PushDominoes(string dominoes) {
        int n = dominoes.Length;
        int[] force = new int[n];
        
        int f = 0;
        // Left to right: apply rightward forces
        for (int i = 0; i < n; i++) {
            if (dominoes[i] == 'R') f = n;
            else if (dominoes[i] == 'L') f = 0;
            else f = Math.Max(f - 1, 0);
            force[i] += f;
        }

        f = 0;
        // Right to left: apply leftward forces
        for (int i = n - 1; i >= 0; i--) {
            if (dominoes[i] == 'L') f = n;
            else if (dominoes[i] == 'R') f = 0;
            else f = Math.Max(f - 1, 0);
            force[i] -= f;
        }

        // Build final state
        char[] result = new char[n];
        for (int i = 0; i < n; i++) {
            if (force[i] > 0) result[i] = 'R';
            else if (force[i] < 0) result[i] = 'L';
            else result[i] = '.';
        }

        return new string(result);
    }
}

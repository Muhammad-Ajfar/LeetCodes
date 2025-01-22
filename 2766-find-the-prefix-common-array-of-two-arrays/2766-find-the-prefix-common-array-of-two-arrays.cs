public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B) {
        int len = A.Length;
        int count = 0;
        int[] frequencies = new int[len + 1];
        int[] res = new int[len];

        for (int i = 0; i < len; i++) {
            if (++frequencies[A[i]] == 2) count++;
            if (++frequencies[B[i]] == 2) count++;
            res[i] = count;
        }

        return res;
    }
}

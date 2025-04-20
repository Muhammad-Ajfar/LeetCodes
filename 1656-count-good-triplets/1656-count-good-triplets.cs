public class Solution {
    public int CountGoodTriplets(int[] arr, int a, int b, int c) {
        int n = arr.Length;
        int count = 0;
        for (int i = 0; i < n - 2; i++) {
            for (int j = i + 1; j < n - 1; j++) {
                int ijDiff = Math.Abs(arr[i] - arr[j]);
                if (ijDiff > a) continue;
                for (int k = j + 1; k < n; k++) {
                    int jkDiff = Math.Abs(arr[j] - arr[k]);
                    if (jkDiff > b) continue;
                    int ikDiff = Math.Abs(arr[i] - arr[k]);
                    if (ikDiff <= c) count++;
                }
            }
        }
        return count;
    }
}
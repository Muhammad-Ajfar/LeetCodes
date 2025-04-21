public class Solution {
    public long GoodTriplets(int[] nums1, int[] nums2) {
        int n = nums1.Length;
        int[] posInNums2 = new int[n];
        for (int i = 0; i < n; i++) {
            posInNums2[nums2[i]] = i;
        }

        int[] mapped = new int[n];
        for (int i = 0; i < n; i++) {
            mapped[i] = posInNums2[nums1[i]];
        }

        // BIT (Fenwick Tree) helpers
        int[] bit = new int[n + 2];
        void Update(int index, int delta) {
            index++;
            while (index <= n + 1) {
                bit[index] += delta;
                index += index & -index;
            }
        }
        int Query(int index) {
            index++;
            int sum = 0;
            while (index > 0) {
                sum += bit[index];
                index -= index & -index;
            }
            return sum;
        }

        // Count of elements to the left smaller than current
        int[] leftSmaller = new int[n];
        for (int i = 0; i < n; i++) {
            leftSmaller[i] = Query(mapped[i] - 1);
            Update(mapped[i], 1);
        }

        // Reset BIT
        Array.Clear(bit, 0, bit.Length);

        // Count of elements to the right greater than current
        int[] rightGreater = new int[n];
        for (int i = n - 1; i >= 0; i--) {
            rightGreater[i] = Query(n - 1) - Query(mapped[i]);
            Update(mapped[i], 1);
        }

        long count = 0;
        for (int i = 0; i < n; i++) {
            count += (long)leftSmaller[i] * rightGreater[i];
        }

        return count;
    }
}

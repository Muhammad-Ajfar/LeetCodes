public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m = nums1.Length;
        int n = nums2.Length;
        int totalLength = m + n;
        int midIndex = totalLength / 2;

        int j = 0, k = 0; // Pointers for nums1 and nums2
        int a = 0, b = 0; // Last two values for median calculation

        for (int i = 0; i <= midIndex; i++) {
            b = a;

            // Handle out-of-bounds cases
            if (j < m && (k >= n || nums1[j] < nums2[k])) {
                a = nums1[j];
                j++;
            } else {
                a = nums2[k];
                k++;
            }
        }

        // If total length is even, return the average of the middle two numbers
        if (totalLength % 2 == 0) {
            return ((double)a + b) / 2;
        } else {
            return a; // If odd, return the middle number
        }
    }
}

public class Solution {
    public int[][] MergeArrays(int[][] nums1, int[][] nums2) {
        int i = 0, j = 0;
        List<int[]> mergedList = new List<int[]>();

        while (i < nums1.Length && j < nums2.Length) {
            if (nums1[i][0] == nums2[j][0]) {
                mergedList.Add(new int[] { nums1[i][0], nums1[i][1] + nums2[j][1] });
                i++;
                j++;
            } else if (nums1[i][0] < nums2[j][0]) {
                mergedList.Add(nums1[i]);
                i++;
            } else {
                mergedList.Add(nums2[j]);
                j++;
            }
        }

        while (i < nums1.Length) {
            mergedList.Add(nums1[i++]);
        }

        while (j < nums2.Length) {
            mergedList.Add(nums2[j++]);
        }

        return mergedList.ToArray();
    }
}

public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> set2 = new HashSet<int>(nums2);
        HashSet<int> diff1 = new HashSet<int>();
        HashSet<int> diff2 = new HashSet<int>();

        foreach (int num in nums1) {
            if (!set2.Contains(num)) {
                diff1.Add(num);
            }
        }

        foreach (int num in nums2) {
            if (!set1.Contains(num)) {
                diff2.Add(num);
            }
        }

        return new List<IList<int>> { diff1.ToList(), diff2.ToList() };
    }
}

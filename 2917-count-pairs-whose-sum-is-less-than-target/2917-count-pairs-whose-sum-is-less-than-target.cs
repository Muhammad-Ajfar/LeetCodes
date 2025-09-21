public class Solution {
    public int CountPairs(IList<int> nums, int target) {
        List<int> sorted = new List<int>(nums);
        sorted.Sort();

        int left = 0, right = sorted.Count - 1;
        int count = 0;

        while (left < right) {
            if (sorted[left] + sorted[right] < target) {
                count += (right - left);
                left++;
            } else {
                right--;
            }
        }

        return count;
    }
}
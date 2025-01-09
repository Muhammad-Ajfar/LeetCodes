public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        List<int> result = new List<int>();
        foreach (int num in nums) {
            int index = Math.Abs(num) - 1; // Find the corresponding index
            if (nums[index] < 0) {
                result.Add(Math.Abs(num)); // Number is a duplicate
            } else {
                nums[index] = -nums[index]; // Mark the index as visited
            }
        }
        return result;
    }
}

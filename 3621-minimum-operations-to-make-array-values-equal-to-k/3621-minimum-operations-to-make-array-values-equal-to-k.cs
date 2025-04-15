public class Solution {
    public int MinOperations(int[] nums, int k) {
        bool[] seen = new bool[101]; // Tracks if we've seen a number > k
        int operations = 0;

        foreach (int num in nums) {
            if (num < k) return -1; // Early exit if impossible
            if (num > k && !seen[num]) {
                seen[num] = true;
                operations++;
            }
        }

        return operations;
    }
}
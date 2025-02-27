public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
        int n = nums.Length;
        StringBuilder result = new StringBuilder();
        
        // Create a string where the i-th character differs from nums[i][i]
        for (int i = 0; i < n; i++) {
            char currentChar = nums[i][i];
            result.Append(currentChar == '0' ? '1' : '0');
        }
        
        return result.ToString();
    }
}
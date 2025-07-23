public class Solution {
    public int MaximumUniqueSubarray(int[] nums) {
        bool[] seen = new bool[10001]; // Since nums[i] <= 10^4
        int maxSum = 0;
        int currentSum = 0;
        int left = 0;

        for (int right = 0; right < nums.Length; right++) {
            int currentNum = nums[right];
            
            while (seen[currentNum]) {
                seen[nums[left]] = false;
                currentSum -= nums[left];
                left++;
            }
            
            seen[currentNum] = true;
            currentSum += currentNum;
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }
}
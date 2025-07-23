public class Solution {
    public int MaximumUniqueSubarray(int[] nums) {
        HashSet<int> uniqueElements = new HashSet<int>();
        int maxSum = 0;
        int currentSum = 0;
        int left = 0;

        for (int right = 0; right < nums.Length; right++) {
            int currentNum = nums[right];
            
            while (uniqueElements.Contains(currentNum)) {
                uniqueElements.Remove(nums[left]);
                currentSum -= nums[left];
                left++;
            }
            
            uniqueElements.Add(currentNum);
            currentSum += currentNum;
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }
}
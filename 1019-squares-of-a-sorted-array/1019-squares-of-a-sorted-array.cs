public class Solution {
    public int[] SortedSquares(int[] nums) {
        int len = nums.Length;
        int[] result = new int[len];
        int left = 0, right = len - 1;
        int index = len - 1;

        while (left <= right) {
            int leftSquare = nums[left] * nums[left];
            int rightSquare = nums[right] * nums[right];

            if (leftSquare > rightSquare) {
                result[index] = leftSquare;
                left++;
            } else {
                result[index] = rightSquare;
                right--;
            }
            index--;
        }

        return result;
    }
}

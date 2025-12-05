public class Solution {
    public int CountPartitions(int[] nums) {
        int sum = 0;

        foreach(int num in nums)
        {
            sum += num;  
        }
        return sum%2 == 0? nums.Length-1 : 0;
    }
}
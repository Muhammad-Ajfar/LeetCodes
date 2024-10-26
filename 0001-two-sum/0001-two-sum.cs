public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] arr =new int[2];
        int a;
        for(int i=0;i<nums.Length;i++)
        {
            a=Array.IndexOf(nums,target-nums[i],i+1);
            if(a>=0)
            {
                arr[0]=a;
                arr[1]=i;
                break;
            }
        }
        return arr;
    }
}
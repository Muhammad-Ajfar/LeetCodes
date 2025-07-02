public class Solution {
    public int[] TransformArray(int[] nums) {
        int n = nums.Length;
        var res = new int[n];
        foreach (int num in nums) {
            if (num % 2 == 1) {
                res[--n] = 1;
            }
        }
        return res;
    }
}

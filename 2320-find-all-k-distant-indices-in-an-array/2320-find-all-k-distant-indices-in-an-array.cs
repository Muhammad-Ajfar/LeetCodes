public class Solution {
    public IList<int> FindKDistantIndices(int[] nums, int key, int k) {
        List<int> result = new List<int>();
        int n = nums.Length;
        int farthest = -1;
        
        for (int j = 0; j < n; j++) {
            if (nums[j] == key) {
                int start = Math.Max(farthest + 1, j - k);
                int end = Math.Min(n - 1, j + k);
                
                for (int i = start; i <= end; i++) {
                    result.Add(i);
                }
                
                farthest = end;
            }
        }
        
        return result;
    }
}
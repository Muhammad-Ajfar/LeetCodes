public class Solution {
    public IList<int> Intersection(int[][] nums) {
        int[] frequency = new int[1001]; // since numbers are from 1 to 1000
        int numOfArrays = nums.Length;
        List<int> result = new List<int>();
        
        foreach (var array in nums) {
            foreach (var num in array) {
                frequency[num]++;
            }
        }
        
        for (int i = 1; i <= 1000; i++) {
            if (frequency[i] == numOfArrays) {
                result.Add(i);
            }
        }
        
        return result;
    }
}
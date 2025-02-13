public class Solution {
    public int TupleSameProduct(int[] nums) {
        int res = 0;
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        
        // Calculate the frequency of each product
        for(int i = 0; i < nums.Length - 1; i++) {
            for(int j = i + 1; j < nums.Length; j++) {
                int prod = nums[i] * nums[j];
                if (frequencyMap.ContainsKey(prod)) {
                    frequencyMap[prod]++;
                } else {
                    frequencyMap[prod] = 1;
                }
            }
        }
        
        foreach (var kvp in frequencyMap) {
            if(kvp.Value > 1) {
                // Each pair can be arranged in 8 different ways
                res += kvp.Value * (kvp.Value - 1) * 4 ;
            }
        }
        
        return res;
    }
}
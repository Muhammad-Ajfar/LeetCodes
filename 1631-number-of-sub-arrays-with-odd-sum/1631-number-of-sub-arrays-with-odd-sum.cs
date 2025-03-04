public class Solution {
    public int NumOfSubarrays(int[] arr) {
        long evenSums = 1;
        long oddSums = 0;
        long prefSum = 0;
        long res = 0;
        int MOD = 1000000007;

        foreach (int num in arr) 
        {
            prefSum += num;

            if (prefSum % 2 == 1) 
            {
                oddSums++;
                res = (res + evenSums) % MOD;
            } 
            else 
            {
                evenSums++;
                res = (res + oddSums) % MOD;
            }
        }
        
        return (int) res;
    }
}

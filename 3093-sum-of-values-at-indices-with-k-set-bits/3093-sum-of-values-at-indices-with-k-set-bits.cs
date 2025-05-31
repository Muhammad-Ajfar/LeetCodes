public class Solution {
    public int SumIndicesWithKSetBits(IList<int> nums, int k) {
        int sum = 0;
        for (int i = 0; i < nums.Count; i++) {
            if (CountBits(i) == k)
                sum += nums[i];
        }
        return sum;
    }

    private int CountBits(int n) {
        int count = 0;
        while (n > 0) {
            n &= (n - 1); // clear the least significant bit set
            count++;
        }
        return count;
    }
}

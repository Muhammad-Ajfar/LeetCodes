public class Solution {
    public bool DivideArray(int[] nums) {
        int[] map = new int[501];

        foreach (int num in nums) {
            map[num]++;
        }

        for (int i = 1; i <= 500; i++) {
            if (map[i] % 2 == 1) {
                return false;
            }
        }

        return true;
    }
}

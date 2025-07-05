public class Solution {
    public int FindLucky(int[] arr) {
        int[] freq = new int[501];
        foreach(int num in arr) {
            freq[num]++;
        }
        for(int i = 500; i >= 1; i--) {
            if(i == freq[i]) {
                return i;
            }
        }
        return -1;
    }
}
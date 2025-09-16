public class Solution {
    public int FindCenter(int[][] e) => e[0][0] == e[1][0] | e[0][0] == e[1][1] ? e[0][0] : e[0][1];

}
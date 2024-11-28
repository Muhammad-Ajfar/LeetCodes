public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int count = 0;
        foreach (char jewel in jewels) {
            count += stones.Count(stone => stone == jewel);
        }
        return count;
    }
}

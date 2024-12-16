public class Solution {
    public long PickGifts(int[] gifts, int k) {
        for (int i = 0; i < k; i++) {
            int maxIndex = Array.IndexOf(gifts, gifts.Max());
            int maxValue = gifts[maxIndex];
            gifts[maxIndex] = (int)Math.Floor(Math.Sqrt(maxValue));
        }
        return gifts.Sum(x => (long)x);
    }
}

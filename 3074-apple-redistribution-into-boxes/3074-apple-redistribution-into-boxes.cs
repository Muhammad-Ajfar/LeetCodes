public class Solution {
    public int MinimumBoxes(int[] apple, int[] capacity) {
        int totalApples = 0;
        for (int i = 0; i < apple.Length; i++) {
            totalApples += apple[i];
        }
        
        Array.Sort(capacity);
        
        int sum = 0;
        int boxesUsed = 0;
        
        for (int i = capacity.Length - 1; i >= 0; i--) {
            sum += capacity[i];
            boxesUsed++;
            if (sum >= totalApples) {
                return boxesUsed;
            }
        }
        
        return capacity.Length;
    }
}
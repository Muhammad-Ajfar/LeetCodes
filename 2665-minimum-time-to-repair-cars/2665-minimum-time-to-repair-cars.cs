public class Solution {
    public long RepairCars(int[] ranks, int cars) {
        long left = 1;
        long right = (long)ranks.Min() * cars * cars;
        
        while (left < right) {
            long mid = left + (right - left) / 2;
            long total = 0;
            
            foreach (int r in ranks) {
                total += (long)Math.Sqrt(mid / r);
                if (total >= cars) break;
            }
            
            if (total >= cars) {
                right = mid;
            } else {
                left = mid + 1;
            }
        }
        
        return left;
    }
}
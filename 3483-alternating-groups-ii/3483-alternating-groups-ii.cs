public class Solution {
    public int NumberOfAlternatingGroups(int[] colors, int k) {
        int n = colors.Length;
        int count = 0;
        bool isAlternating = true;

        // Step 1: Check the first window of size k
        for (int j = 0; j < k - 1; j++) {
            if (colors[j] == colors[j + 1]) {
                isAlternating = false;
                break;
            }
        }
        if (isAlternating) count++;

        // Step 2: Slide the window across the circular array
        for (int i = 1; i < n; i++) {
            int prevStart = (i - 1) % n;
            int newEnd = (i + k - 1) % n;

            // Remove the old transition: prevStart to (prevStart+1)
            if (colors[prevStart] == colors[(prevStart + 1) % n]) {
                isAlternating = false;
            }

            // Add the new transition: (newEnd-1) to newEnd
            if (colors[newEnd] == colors[(newEnd - 1 + n) % n]) {
                isAlternating = false;
            }

            // If window remains valid, count it
            if (isAlternating) count++;
            else { 
                // Recheck full window only if it was invalidated
                isAlternating = true;
                for (int j = 0; j < k - 1; j++) {
                    if (colors[(i + j) % n] == colors[(i + j + 1) % n]) {
                        isAlternating = false;
                        break;
                    }
                }
                if (isAlternating) count++;
            }
        }

        return count;
    }
}

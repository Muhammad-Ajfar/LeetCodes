public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        int[] mismatchIndices = new int[2];
        int count = 0;

        for (int i = 0; i < s1.Length; i++) {
            if (s1[i] != s2[i]) {
                if (count >= 2) return false;
                mismatchIndices[count] = i;
                count++;
            }
        }

        if (count == 0) return true;
        if (count != 2) return false;

        // Check if swapping the two mismatched characters makes the strings equal
        return s1[mismatchIndices[0]] == s2[mismatchIndices[1]] && 
               s1[mismatchIndices[1]] == s2[mismatchIndices[0]];
    }
}
public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        HashSet<char> allowedSet = new HashSet<char>(allowed);

        int count = words.Length;

        foreach (var word in words)
        {
            foreach (char c in word)
            {
                if (!allowedSet.Contains(c))
                {
                    count--;
                    break;
                }
            }
        }

        return count;
    }
}
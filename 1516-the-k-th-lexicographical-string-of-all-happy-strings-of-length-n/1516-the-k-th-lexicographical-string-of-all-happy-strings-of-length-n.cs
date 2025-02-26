public class Solution {
    public string GetHappyString(int n, int k) {
        List<string> happyStrings = new List<string>();
        Backtrack(happyStrings, new char[n], 0, n);
        
        // Check if there are at least k happy strings
        if (happyStrings.Count < k)
        {
            return "";
        }
        
        // Return the k-th string (1-indexed)
        return happyStrings[k - 1];
    }

    private void Backtrack(List<string> happyStrings, char[] current, int index, int n)
    {
        // If the current string is of length n, add it to the list
        if (index == n)
        {
            happyStrings.Add(new string(current));
            return;
        }

        // Try adding 'a', 'b', or 'c' to the current string
        for (char ch = 'a'; ch <= 'c'; ch++)
        {
            // Ensure the current character is not the same as the previous one
            if (index == 0 || current[index - 1] != ch)
            {
                current[index] = ch;
                Backtrack(happyStrings, current, index + 1, n);
            }
        }

    }
}
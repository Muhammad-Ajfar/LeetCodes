public class Solution
{
    public int NumTilePossibilities(string tiles)
    {
        // Step 1: Count the frequency of each letter
        Dictionary<char, int> frequencyMap = new Dictionary<char, int>();
        foreach (char c in tiles)
        {
            if (frequencyMap.ContainsKey(c))
                frequencyMap[c]++;
            else
                frequencyMap[c] = 1;
        }

        // Step 2: Use backtracking to count all possible sequences
        return Backtrack(frequencyMap);
    }

    private int Backtrack(Dictionary<char, int> frequencyMap)
    {
        int count = 0;

        // Iterate through each unique letter in the frequency map
        foreach (var pair in frequencyMap)
        {
            if (pair.Value > 0) // If the letter is still available
            {
                // Use one instance of the letter
                frequencyMap[pair.Key]--;
                // Count this sequence and recursively explore further
                count += 1 + Backtrack(frequencyMap);
                // Backtrack: restore the letter's count
                frequencyMap[pair.Key]++;
            }
        }

        return count;
    }
}
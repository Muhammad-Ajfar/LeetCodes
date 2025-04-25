public class Solution {
    public int NumRabbits(int[] answers) {
        Dictionary<int, int> freqMap = new Dictionary<int, int>();
        int count = 0;

        foreach (int num in answers) {
            if (!freqMap.ContainsKey(num))
                freqMap[num] = 0;
            freqMap[num]++;
        }

        foreach (var kvp in freqMap) {
            int answer = kvp.Key;
            int freq = kvp.Value;
            int groupSize = answer + 1;

            int numberOfGroups = (freq + groupSize - 1) / groupSize;
            count += numberOfGroups * groupSize;
        }

        return count;
    }
}

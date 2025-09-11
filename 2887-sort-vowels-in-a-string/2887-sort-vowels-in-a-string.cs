public class Solution {
    public string SortVowels(string s) {
        var vowels = "AEIOUaeiou";
        var temp = s.ToCharArray();
        var vowelIndices = new List<int>();
        int[] count = new int[128];

        for (int i = 0; i < s.Length; i++) {
            char ch = s[i];
            if (vowels.Contains(ch)) {
                vowelIndices.Add(i);
                count[ch]++;
            }
        }

        int idx = 0;
        foreach (var v in vowels) {
            while (count[v]-- > 0) {
                temp[vowelIndices[idx++]] = v;
            }
        }

        return new string(temp);
    }
}
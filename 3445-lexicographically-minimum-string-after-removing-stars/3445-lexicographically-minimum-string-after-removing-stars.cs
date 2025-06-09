public class Solution {
    public string ClearStars(string s) {
        // Create 26 lists for 'a' to 'z'
        var charPos = new List<List<int>>();
        for (int i = 0; i < 26; i++) {
            charPos.Add(new List<int>());
        }

        var arr = s.ToCharArray();

        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] == '*') {
                // Find the smallest character with a recorded position
                for (int j = 0; j < 26; j++) {
                    if (charPos[j].Count > 0) {
                        int pos = charPos[j][charPos[j].Count - 1];
                        charPos[j].RemoveAt(charPos[j].Count - 1);
                        arr[pos] = '*';
                        break;
                    }
                }
            } else {
                charPos[arr[i] - 'a'].Add(i);
            }
        }

        // Build result
        var result = new StringBuilder();
        foreach (char c in arr) {
            if (c != '*') {
                result.Append(c);
            }
        }

        return result.ToString();
    }
}

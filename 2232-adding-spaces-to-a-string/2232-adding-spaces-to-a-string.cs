public class Solution {
public string AddSpaces(string s, int[] spaces) {
    var sb = new StringBuilder(s.Length + spaces.Length);
    int spaceIndex = 0;

    for (int i = 0; i < s.Length; i++) {
        if (spaceIndex < spaces.Length && i == spaces[spaceIndex]) {
            sb.Append(' ');
            spaceIndex++;
        }
        sb.Append(s[i]);
    }
    return sb.ToString();
}

}
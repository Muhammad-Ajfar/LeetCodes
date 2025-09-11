public class Solution {
    public string SortVowels(string s) {
        var vowels = new HashSet<char>(){ 'a','e','i','o','u','A','E','I','O','U'};
        var vowelList = new List<char>();

        foreach(char ch in s) {
            if(vowels.Contains(ch)) vowelList.Add(ch);
        }

        vowelList.Sort();

        var sb = new StringBuilder();
        int idx = 0;
        foreach(char ch in s) {
            if(vowels.Contains(ch)) sb.Append(vowelList[idx++]);
            else sb.Append(ch);
        }

        return sb.ToString();
    }
}
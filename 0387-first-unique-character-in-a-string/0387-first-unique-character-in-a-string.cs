public class Solution {
    public int FirstUniqChar(string s) {
        int index;
        foreach(char ch in s)
        {
            index = s.IndexOf(ch);
            if(index == s.LastIndexOf(ch))
            {
                return index;
            }
        }
        return -1;
    }
}
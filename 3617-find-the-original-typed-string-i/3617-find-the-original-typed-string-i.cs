public class Solution {
    public int PossibleStringCount(string word) {
        char cur = word[0];
        int res = 0;

        foreach(char c in word)
        {
            if(c == cur) res++;
            else cur = c;
        }

        return res;
    }
}
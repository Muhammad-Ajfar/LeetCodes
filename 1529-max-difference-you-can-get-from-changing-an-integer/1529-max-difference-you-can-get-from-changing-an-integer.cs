public class Solution {
    public int MaxDiff(int num) {
        string sNum = num.ToString();
        int a = GetMax(sNum);
        int b = GetMin(sNum);
        return a - b;
    }
    
    private int GetMax(string s) {
        foreach (char c in s) {
            if (c != '9') {
                return int.Parse(s.Replace(c, '9'));
            }
        }
        return int.Parse(s);
    }
    
    private int GetMin(string s) {
        if (s[0] != '1') {
            return int.Parse(s.Replace(s[0], '1'));
        }
        foreach (char c in s) {
            if (c != '0' && c != '1') {
                return int.Parse(s.Replace(c, '0'));
            }
        }
        return int.Parse(s);
    }
}
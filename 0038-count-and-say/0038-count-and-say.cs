public class Solution {
    public string CountAndSay(int n) {
        string s = "1";
        for(int i = 1; i < n; i++) s = Rle(s);
        
        return s;
    }
    
    private string Rle(string str) {
        int count = 1;
        char cur = str[0];
        StringBuilder res = new StringBuilder();
        
        for(int i = 1; i < str.Length; i++) {
            if(str[i] == cur) {
                count++;
            } else {
                res.Append(count);
                res.Append(cur);
                cur = str[i];
                count = 1;
            }
        }
        
        // Append the last group
        res.Append(count);
        res.Append(cur);
        
        return res.ToString();
    }
}
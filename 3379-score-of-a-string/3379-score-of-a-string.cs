public class Solution {
    public int ScoreOfString(string s) {
        int score = 0;
        for(int i =1; i < s.Length; i++)
        {
            score += Math.Abs((int)s[i-1] - (int)s[i]);
        }
        return score;
    }
}
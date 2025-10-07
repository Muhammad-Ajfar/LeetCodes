public class Solution {
    public int CountSeniors(string[] details) {
        int count = 0;
        foreach (var s in details)
        {
            int age = (s[11] - '0') * 10 + (s[12] - '0');
            if (age > 60)
                count++;
        }
        return count;
    }
}

public class Solution {
    public string MaximumOddBinaryNumber(string s) {
        int c1 = 0;
        foreach(char bit in s) {
            if(bit == '1') c1++;
        }
        var sb = new StringBuilder(new string('1', c1 - 1));
        sb.Append(new string('0', s.Length - c1));
        sb.Append('1');
        return sb.ToString();
    }
}
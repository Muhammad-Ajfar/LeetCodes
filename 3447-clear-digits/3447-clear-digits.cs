using System.Text;

public class Solution {
    public string ClearDigits(string s) {
        StringBuilder str = new StringBuilder();

        foreach (char c in s) {
            if (char.IsDigit(c)) {
                if (str.Length > 0) {
                    str.Length--; // Removes the last character
                }
            } else {
                str.Append(c);
            }
        }

        return str.ToString();
    }
}

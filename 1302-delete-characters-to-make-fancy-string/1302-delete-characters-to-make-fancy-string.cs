public class Solution
{
    public string MakeFancyString(string s)
    {
        var sb = new StringBuilder();

        sb.Append(s[0]);

        for (int i = 1; i < s.Length - 1; i++)
        {
            // Skip the current character if it creates a triplet
            if (s[i - 1] == s[i] && s[i] == s[i + 1])
                continue;

            sb.Append(s[i]);
        }

        if(s.Length > 1) sb.Append(s[^1]);

        return sb.ToString();
    }
}
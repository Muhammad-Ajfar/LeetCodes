public class Solution
{
    public string LargestGoodInteger(string num)
    {
        string result = "";

        for (int i = 0; i <= num.Length - 3; i++)
        {
            string sub = num.Substring(i, 3);

            // Check if all 3 characters are the same
            if (sub[0] == sub[1] && sub[1] == sub[2])
            {
                // Compare lexicographically (since both are strings of equal length)
                if (string.Compare(sub, result) > 0)
                {
                    result = sub;
                }
            }
        }

        return result;
    }
}
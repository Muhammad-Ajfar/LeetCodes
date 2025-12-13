public class Solution {
    public IList<string> ValidateCoupons( string[] code, string[] businessLine, bool[] isActive)
    {
        var result = new List<string>();

        var map = new Dictionary<string, PriorityQueue<string, string>>
        {
            ["electronics"] = new(StringComparer.Ordinal),
            ["grocery"] = new(StringComparer.Ordinal),
            ["pharmacy"] = new(StringComparer.Ordinal),
            ["restaurant"] = new(StringComparer.Ordinal)
        };

        for (int i = 0; i < code.Length; i++)
        {
            if (!isActive[i]) continue;
            if (!CodeValidator(code[i])) continue;

            if (map.TryGetValue(businessLine[i], out var pq))
                pq.Enqueue(code[i], code[i]);
        }

        foreach (var key in new[] { "electronics", "grocery", "pharmacy", "restaurant" })
        {
            var pq = map[key];
            while (pq.Count > 0) result.Add(pq.Dequeue());
        }

        return result;
    }

    private static bool CodeValidator(string input)
    {
        if (string.IsNullOrEmpty(input)) return false;

        foreach (char c in input)
        {
            if (!((c >= 'a' && c <= 'z') ||
                (c >= 'A' && c <= 'Z') ||
                (c >= '0' && c <= '9') ||
                c == '_'
            )) return false;
        }
        return true;
    }
}
public class Solution {
    private static readonly string[] Categories = ["electronics", "grocery", "pharmacy", "restaurant"];

    public IList<string> ValidateCoupons( string[] code, string[] businessLine, bool[] isActive)
    {
        var result = new List<string>();

        var map = Categories.ToDictionary( c => c, _ => new PriorityQueue<string, string>(StringComparer.Ordinal)
        );

        for (int i = 0; i < code.Length; i++)
        {
            if (!isActive[i]) continue;
            if (!CodeValidator(code[i])) continue;

            if (map.TryGetValue(businessLine[i], out var pq))
                pq.Enqueue(code[i], code[i]);
        }

        foreach (var key in Categories)
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
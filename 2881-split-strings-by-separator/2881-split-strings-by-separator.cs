public class Solution {
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator) 
    {
        List<string> result = [];
        
        foreach (var word in words)
        {
            var parts = word.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            result.AddRange(parts);
        }
        
        return result;
    }
}
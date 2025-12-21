public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int index = ruleKey switch {
            "type" => 0,
            "color" => 1,
            "name" => 2,
            _ => throw new ArgumentException("Invalid ruleKey")
        };
        
        int count = 0;
        foreach (var item in items) {
            if (item[index] == ruleValue) {
                count++;
            }
        }
        return count;
    }
}
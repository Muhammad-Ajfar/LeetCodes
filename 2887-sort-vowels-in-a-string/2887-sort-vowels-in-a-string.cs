public class Solution {
    public string SortVowels(string s) {
        var pq = new PriorityQueue<char, char>();
        var vowels = new HashSet<char>(){'a','e','i','o','u','A','E','I','O','U'};

        foreach(char ch in s) {
            if(vowels.Contains(ch))
                pq.Enqueue(ch, ch);
        }

        var sb = new StringBuilder();

        foreach(char ch in s) {
            if(vowels.Contains(ch)) 
                sb.Append(pq.Dequeue());
            else 
                sb.Append(ch);
        }

        return sb.ToString();
    }

}
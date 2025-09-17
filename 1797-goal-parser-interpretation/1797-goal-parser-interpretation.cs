public class Solution {
    public string Interpret(string command) {
        var sb = new StringBuilder();

        for(int i = 0; i < command.Length; i++)
        {
            if(command[i] == 'G')
                sb.Append('G');
            else if(command[i+1] == ')') {
                sb.Append('o');
                i++; // skip over ')'
            }
            else {
                sb.Append("al");
                i += 3; // skip over "al)"
            }
        }

        return sb.ToString();
    }
}
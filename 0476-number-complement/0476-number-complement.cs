public class Solution {
    public int FindComplement(int num) {
        // Convert the number to a binary string
        string binary = Convert.ToString(num, 2);
        
        // Use a StringBuilder for efficient character replacements
        var result = new System.Text.StringBuilder(binary.Length);
        foreach (char bit in binary)
        {
            result.Append(bit == '0' ? '1' : '0');
        }
        
        // Convert the flipped binary string back to an integer
        return Convert.ToInt32(result.ToString(), 2);
    }
}

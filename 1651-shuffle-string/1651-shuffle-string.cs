public class Solution {
    public string RestoreString(string s, int[] indices) {
        int len=s.Length;
        char[] str = new char[len];
        for(int i=0;i<len;i++)
        {
            str[indices[i]]=s[i];
        }
        return String.Join("",str);
    }
}
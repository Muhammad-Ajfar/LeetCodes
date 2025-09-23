public class Solution {
    public int CompareVersion(string version1, string version2) {
        var arr1 = version1.Split('.');
        var arr2 = version2.Split('.');
        
        int n = Math.Max(arr1.Length, arr2.Length);
        
        for (int i = 0; i < n; i++) {
            int v1 = i < arr1.Length ? int.Parse(arr1[i]) : 0;
            int v2 = i < arr2.Length ? int.Parse(arr2[i]) : 0;
            
            if (v1 < v2) return -1;
            if (v1 > v2) return 1;
        }
        
        return 0;
    }
}
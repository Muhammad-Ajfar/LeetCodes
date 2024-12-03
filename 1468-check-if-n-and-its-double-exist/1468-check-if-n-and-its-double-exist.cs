public class Solution {
    public bool CheckIfExist(int[] arr) {

        foreach(int n in arr)
        {
            if(arr.Contains(2*n) && n!=0)
            {
                return true;
            }
        }
        if(arr.Count(x => x == 0) > 1)
        {
            return true;
        }
        return false;
    }
}
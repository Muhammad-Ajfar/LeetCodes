public class Solution {
    public bool IsPowerOfThree(int n) {
        int a = n;
        while(a>1)
        {
            if(a%3!=0) return false;
            a=a/3;
        }
        return a==1;
    }
}
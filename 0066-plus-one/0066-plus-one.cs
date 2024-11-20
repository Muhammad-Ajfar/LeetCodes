public class Solution {
    public int[] PlusOne(int[] digits) {
        for(int i=digits.Length-1;i>=0;i--)
        {
            if(digits[i]!=9)
            {
                digits[i] += 1;
                return digits;
            }
            else
            {
                digits[i]= 0;
            }
        }
        if(digits[0]==0)
        {
            int[] ar2 = new int[digits.Length+1];
            ar2[0]=1;
            Array.Copy(digits, 0, ar2, 1, digits.Length);
            return ar2;
        }
        return digits;
    }
}
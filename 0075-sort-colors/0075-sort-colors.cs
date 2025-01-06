public class Solution {
    public void SortColors(int[] nums) {
        int red = 0, white = 0, blue = 0;
        foreach(int i in nums)
        {
            switch(i)
            {
                case 0 : red++;
                         break;
                case 1 : white++;
                         break;
                case 2 : blue++;
                         break;
            }
        }
        for(int i = 0 ; i < nums.Length; i++)
        {
            if(i < red)
            {
                nums[i] = 0;
            }
            else if(i < white + red)
            {
                nums[i] = 1;
            }
            else
            {
                nums[i] = 2;
            }
        }
    }
}
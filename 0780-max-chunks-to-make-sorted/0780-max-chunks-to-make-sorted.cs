public class Solution {
    public int MaxChunksToSorted(int[] arr) {
        int count = 0, sum = 0;
        for(int i = 0 ; i < arr.Length ; i++)
        {
            sum += arr[i];

            if(sum == i * (i+1) / 2)
            {
                count++ ;
            }
        }
        return count;
    }
}
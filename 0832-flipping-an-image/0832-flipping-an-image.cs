public class Solution
{
    public int[][] FlipAndInvertImage(int[][] image)
    {
        int n = image.Length;

        for (int i = 0; i < n; i++)
        {
            int left = 0, right = n - 1;

            while (left <= right)
            {
                int temp = image[i][left] ^ 1;
                image[i][left] = image[i][right] ^ 1;
                image[i][right] = temp;

                left++;
                right--;
            }
        }

        return image;
    }
}
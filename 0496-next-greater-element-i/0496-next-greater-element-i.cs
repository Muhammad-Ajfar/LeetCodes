public class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var nextGreater = new Dictionary<int, int>();
        var stack = new Stack<int>();

        for (int i = nums2.Length - 1; i >= 0; i--)
        {
            int current = nums2[i];

            while (stack.Count > 0 && stack.Peek() <= current)
            {
                stack.Pop();
            }

            nextGreater[current] = stack.Count == 0 ? -1 : stack.Peek();

            stack.Push(current);
        }

        int[] result = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; i++)
            result[i] = nextGreater[nums1[i]];

        return result;
    }
}
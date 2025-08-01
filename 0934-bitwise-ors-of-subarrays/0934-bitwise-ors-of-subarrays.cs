public class Solution {
    public int SubarrayBitwiseORs(int[] arr) {
        HashSet<int> result = new HashSet<int>();
        HashSet<int> prev = new HashSet<int>();

        foreach (int num in arr) {
            HashSet<int> curr = new HashSet<int>();
            curr.Add(num);

            foreach (int x in prev)
                curr.Add(x | num);

            foreach (int x in curr)
                result.Add(x);

            prev = curr;
        }

        return result.Count;
    }
}
public class Solution {
    public string TriangleType(int[] nums) {
        int a = nums[0], b = nums[1], c = nums[2];
        
        if (a > b) { int temp = a; a = b; b = temp; }
        if (a > c) { int temp = a; a = c; c = temp; }
        if (b > c) { int temp = b; b = c; c = temp; }
        
        if (a + b <= c) {
            return "none";
        }
        
        if (a == b && b == c) {
            return "equilateral";
        }
        if (a == b || b == c) {
            return "isosceles";
        }
        return "scalene";
    }
}
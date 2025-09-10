/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int RangeSumBST(TreeNode root, int low, int high) {
        if (root == null) {
            return 0;
        }
        
        int current = (root.val >= low && root.val <= high) ? root.val : 0;

        int leftSum = (root.left != null && root.val > low) 
            ? RangeSumBST(root.left, low, high) : 0;

        int rightSum = (root.right != null && root.val < high) 
            ? RangeSumBST(root.right, low, high) : 0;
        
        return current + leftSum + rightSum;
    }
}
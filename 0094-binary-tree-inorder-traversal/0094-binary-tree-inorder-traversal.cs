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
    public IList<int> InorderTraversal(TreeNode root) {
        var result = new List<int>();
        TraverseInOrder(root, result);
        return result;
    }

    private void TraverseInOrder(TreeNode node, IList<int> result) {
        if (node == null) return;

        // Traverse the left subtree
        TraverseInOrder(node.left, result);

        // Visit the root
        result.Add(node.val);

        // Traverse the right subtree
        TraverseInOrder(node.right, result);
    }
}

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
    public IList<int> PreorderTraversal(TreeNode root) {
        var list = new List<int>();

        if(root != null)Traverse(list, root);
        return list;
    }

    private void Traverse(List<int> l, TreeNode node)
    {
        l.Add(node.val);
        if(node.left != null) Traverse(l, node.left);
        if(node.right != null) Traverse(l, node.right);
    }
}
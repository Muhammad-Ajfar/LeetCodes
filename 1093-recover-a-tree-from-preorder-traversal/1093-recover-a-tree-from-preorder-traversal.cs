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
    public TreeNode RecoverFromPreorder(string traversal) {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        int i = 0;
        
        TreeNode root = null;
        
        while (i < traversal.Length) {
            int depth = 0;
            while (i < traversal.Length && traversal[i] == '-') {
                depth++;
                i++;
            }

            int value = 0;
            while (i < traversal.Length && char.IsDigit(traversal[i])) {
                value = value * 10 + (traversal[i] - '0');
                i++;
            }

            TreeNode node = new TreeNode(value);
            if (depth == 0) {
                root = node;
            } else {
                while (stack.Count > depth) {
                    stack.Pop();
                }
                if (stack.Peek().left == null) {
                    stack.Peek().left = node;
                } else {
                    stack.Peek().right = node;
                }
            }

            stack.Push(node);
        }

        return root;
    }
}

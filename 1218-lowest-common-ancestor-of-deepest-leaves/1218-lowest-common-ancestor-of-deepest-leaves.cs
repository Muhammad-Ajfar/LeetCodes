public class Solution {
    public TreeNode LcaDeepestLeaves(TreeNode root) {
        return Dfs(root).lca;
    }

    private (TreeNode lca, int depth) Dfs(TreeNode node) {
        if (node == null) return (null, 0);

        var left = Dfs(node.left);
        var right = Dfs(node.right);

        if (left.depth == right.depth) {
            return (node, left.depth + 1);
        }

        return left.depth > right.depth 
            ? (left.lca, left.depth + 1) 
            : (right.lca, right.depth + 1);
    }
}

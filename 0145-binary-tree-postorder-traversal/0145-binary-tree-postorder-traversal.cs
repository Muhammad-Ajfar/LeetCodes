public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> res = [];
        Helper(root, res);
        return res;
    }

    private void Helper(TreeNode node, List<int> list)
    {
        if(node == null) return;
        Helper(node.left, list);
        Helper(node.right, list);
        list.Add(node.val);
    }
}
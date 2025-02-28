public class FindElements {
    private HashSet<int> map = new HashSet<int>();

    public FindElements(TreeNode root) {
        if (root == null) {
            return;
        }
        root.val = 0;
        map.Add(0);
        reconstructTree(root);
    }

    private void reconstructTree(TreeNode node) {
        if (node.left != null) {
            node.left.val = node.val * 2 + 1;
            map.Add(node.left.val);
            reconstructTree(node.left);
        }
        if (node.right != null) {
            node.right.val = node.val * 2 + 2;
            map.Add(node.right.val);
            reconstructTree(node.right);
        }
    }

    public bool Find(int target) {
        return map.Contains(target);
    }
}
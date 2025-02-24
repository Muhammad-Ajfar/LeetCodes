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
    public TreeNode ConstructFromPrePost(int[] preorder, int[] postorder) {
        if (preorder == null || postorder == null || preorder.Length == 0 || postorder.Length == 0) {
            return null;
        }
        
        var postorderMap = new Dictionary<int, int>();
        for (int i = 0; i < postorder.Length; i++) {
            postorderMap[postorder[i]] = i;
        }
        
        return BuildTree(preorder, 0, preorder.Length - 1, postorder, 0, postorder.Length - 1, postorderMap);
    }
    
    private TreeNode BuildTree(int[] preorder, int preStart, int preEnd, int[] postorder, int postStart, int postEnd, Dictionary<int, int> postorderMap) {
        if (preStart > preEnd || postStart > postEnd) {
            return null;
        }
        
        int rootVal = preorder[preStart];
        var root = new TreeNode(rootVal);
        
        if (preStart == preEnd) {
            return root;
        }
        
        int leftRootVal = preorder[preStart + 1];
        
        int leftRootIdx = postorderMap[leftRootVal];
        
        int leftSubtreeSize = leftRootIdx - postStart + 1;
        
        root.left = BuildTree(preorder, preStart + 1, preStart + leftSubtreeSize, postorder, postStart, leftRootIdx, postorderMap);
        
        root.right = BuildTree(preorder, preStart + leftSubtreeSize + 1, preEnd, postorder, leftRootIdx + 1, postEnd - 1, postorderMap);
        
        return root;
    }
}
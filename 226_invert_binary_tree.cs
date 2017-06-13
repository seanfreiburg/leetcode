/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        invert(root);
        return root;
    }
    
    public void invert(TreeNode root){
        if (root == null){
            return;
        }
        var hold = root.right;
        root.right = root.left;
        root.left = hold;
        invert(root.left);
        invert(root.right);
    }
}

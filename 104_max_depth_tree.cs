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
    public int MaxDepth(TreeNode root) {
        return depth(root, 0);
    }
    
    public int depth(TreeNode root, int length){
        if (root == null){
            return length;
        }
        
        length += 1;
        var left = depth(root.left, length);
        var right = depth(root.right, length);
        return Math.Max(left, right);
    }
}
